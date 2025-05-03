import { useEffect, useState } from "react";
import { Link, useNavigate } from "react-router-dom";
import {
  Bell,
  Mail,
  User,
  Home as HomeIcon,
  Users,
  Briefcase,
  UserPlus,
  Search as SearchIcon,
  Menu as MenuIcon,
} from "lucide-react";
import { Button } from "@/components/ui/button";
import { ThemeToggle } from "@/components/ThemeToggle";
import {
  DropdownMenu,
  DropdownMenuTrigger,
  DropdownMenuContent,
  DropdownMenuLabel,
  DropdownMenuSeparator,
  DropdownMenuItem,
} from "@/components/ui/dropdown-menu";
import { cn } from "@/lib/utils";
import useAuth from "@/contexts/useAuth";
import { subscribeNotifications, Notification } from "@/services/signalr/notificationHub";
import friendRequestService from "@/services/api/friendRequestService";
import userService from "@/services/api/userService";
import { User as UserModel } from "@/models/user";

// --- Desktop Search Dropdown with live suggestions ---
const DesktopSearch: React.FC = () => {
  const navigate = useNavigate();
  const [q, setQ] = useState("");
  const [results, setResults] = useState<UserModel[]>([]);
  const [open, setOpen] = useState(false);

  // fetch suggestions on q change
  useEffect(() => {
    if (!q.trim()) {
      setResults([]);
      return;
    }
    let cancelled = false;
    userService.getUsers(q).then(users => {
      if (!cancelled) setResults(users);
    });
    return () => {
      cancelled = true;
    };
  }, [q]);

  return (
    <DropdownMenu open={open} onOpenChange={setOpen}>
      <DropdownMenuTrigger asChild>
        <Button variant="ghost" size="icon"><SearchIcon /></Button>
      </DropdownMenuTrigger>
      <DropdownMenuContent align="end" className="w-64 p-2">
        <DropdownMenuLabel>Search Users</DropdownMenuLabel>
        <input
          type="text"
          placeholder="Type to search…"
          className="w-full px-2 py-1 border rounded dark:bg-gray-800 dark:border-gray-700 mb-2"
          value={q}
          onChange={e => setQ(e.target.value)}
        />
        <DropdownMenuSeparator />
        {results.length === 0 ? (
          <DropdownMenuItem disabled>No matches</DropdownMenuItem>
        ) : (
          results.map(u => (
            <DropdownMenuItem
              key={u.id}
              onSelect={() => {
                navigate(`/profile/${u.id}`);
                setOpen(false);
                setQ("");
              }}
            >
              {u.firstName} {u.lastName}
            </DropdownMenuItem>
          ))
        )}
      </DropdownMenuContent>
    </DropdownMenu>
  );
};

// --- Mobile Search in main menu ---
const MobileSearch: React.FC = () => {
  const navigate = useNavigate();
  const [mq, setMq] = useState("");
  const [res, setRes] = useState<UserModel[]>([]);

  useEffect(() => {
    if (!mq.trim()) {
      setRes([]);
      return;
    }
    let cancelled = false;
    userService.getUsers(mq).then(users => {
      if (!cancelled) setRes(users);
    });
    return () => {
      cancelled = true;
    };
  }, [mq]);

  return (
    <>
      <DropdownMenuLabel>Search</DropdownMenuLabel>
      <input
        type="text"
        placeholder="Type to search…"
        className="w-full px-2 py-1 mb-2 border rounded dark:bg-gray-800 dark:border-gray-700"
        value={mq}
        onChange={e => setMq(e.target.value)}
      />
      {res.length === 0 ? (
        <DropdownMenuItem disabled>No matches</DropdownMenuItem>
      ) : (
        res.map(u => (
          <DropdownMenuItem
            key={u.id}
            onSelect={() => {
              navigate(`/profile/${u.id}`);
            }}
          >
            {u.firstName} {u.lastName}
          </DropdownMenuItem>
        ))
      )}
    </>
  );
};

const Navbar: React.FC<{ isAuthenticated?: boolean }> = ({ isAuthenticated = false }) => {
  const [scrolled, setScrolled] = useState(false);
  const [notifications, setNotifications] = useState<Notification[]>([]);
  const navigate = useNavigate();
  const { logout, isAuthenticated: auth } = useAuth();

  useEffect(() => {
    const onScroll = () => setScrolled(window.scrollY > 10);
    window.addEventListener("scroll", onScroll);
    return () => window.removeEventListener("scroll", onScroll);
  }, []);

  useEffect(() => {
    subscribeNotifications(notif => {
      setNotifications(prev => [notif, ...prev]);
    });
  }, []);

  const handleLogout = async () => {
    await logout();
    navigate("/");
  };

  const onNotifClick = (notif: Notification) => {
    if (notif.type === "friend_request") navigate("/friend-requests");
    else navigate(`/home#post-${notif.id}`);
  };

  const handleAccept = async (id?: string) => {
    if (!id) return;
    await friendRequestService.acceptRequest(id);
    setNotifications(n => n.filter(x => x.requestId !== id));
  };

  const handleReject = async (id?: string) => {
    if (!id) return;
    await friendRequestService.rejectRequest(id);
    setNotifications(n => n.filter(x => x.requestId !== id));
  };

  return (
    <header
      className={cn(
        "fixed top-0 w-full z-50 transition-all duration-300",
        scrolled
          ? "bg-white/80 dark:bg-gray-900/80 backdrop-blur-md shadow-md"
          : "bg-transparent"
      )}
    >
      <div className="relative h-16">
        {/* DESKTOP LEFT */}
        {auth && (
          <div className="hidden md:flex absolute left-4 top-1/2 -translate-y-1/2 space-x-2">
            <Link to="/home"><Button variant="ghost" size="icon"><HomeIcon /></Button></Link>
            <Link to="/community"><Button variant="ghost" size="icon"><Users /></Button></Link>
            <Link to="/jobs"><Button variant="ghost" size="icon"><Briefcase /></Button></Link>
            <Link to="/friend-requests"><Button variant="ghost" size="icon"><UserPlus /></Button></Link>
          </div>
        )}

        {/* CENTER LOGO */}
        <div className="absolute inset-0 flex items-center justify-center pointer-events-none">
          <Link to="/" className="pointer-events-auto">
            <span className="font-bold text-2xl text-studybuddy-700 dark:text-studybuddy-400">
              StudyBuddy
            </span>
          </Link>
        </div>

        {/* DESKTOP RIGHT */}
        <div className="hidden md:flex absolute right-4 top-1/2 -translate-y-1/2 items-center space-x-2">
          {auth && <DesktopSearch />}

          {auth && (
            <DropdownMenu>
              <DropdownMenuTrigger asChild>
                <Button variant="ghost" size="icon" className="relative">
                  <Bell />
                  {notifications.length > 0 && (
                    <span className="absolute top-0 right-0 h-2 w-2 rounded-full bg-red-500" />
                  )}
                </Button>
              </DropdownMenuTrigger>
              <DropdownMenuContent align="end" className="max-h-64 overflow-y-auto">
                <DropdownMenuLabel>Notifications</DropdownMenuLabel>
                <DropdownMenuSeparator />
                {notifications.length === 0 && (
                  <DropdownMenuItem disabled>No notifications</DropdownMenuItem>
                )}
                {notifications.map(n =>
                  n.type === "friend_request" ? (
                    <DropdownMenuItem
                      key={n.id}
                      className="flex justify-between items-center"
                      onSelect={() => onNotifClick(n)}
                    >
                      <span>{n.message}</span>
                      <div className="flex space-x-1">
                        <Button size="sm" onClick={() => handleAccept(n.requestId)}>✓</Button>
                        <Button size="sm" variant="destructive" onClick={() => handleReject(n.requestId)}>✕</Button>
                      </div>
                    </DropdownMenuItem>
                  ) : (
                    <DropdownMenuItem key={n.id} onSelect={() => onNotifClick(n)}>
                      {n.message}
                    </DropdownMenuItem>
                  )
                )}
              </DropdownMenuContent>
            </DropdownMenu>
          )}

          {auth && (
            <DropdownMenu>
              <DropdownMenuTrigger asChild>
                <Button variant="ghost" size="icon"><Mail /></Button>
              </DropdownMenuTrigger>
              <DropdownMenuContent align="end">
                <DropdownMenuLabel>Messages</DropdownMenuLabel>
                <DropdownMenuSeparator />
                <DropdownMenuItem>No messages</DropdownMenuItem>
              </DropdownMenuContent>
            </DropdownMenu>
          )}

          <ThemeToggle />

          {auth && (
            <DropdownMenu>
              <DropdownMenuTrigger asChild>
                <Button variant="ghost" size="icon"><User /></Button>
              </DropdownMenuTrigger>
              <DropdownMenuContent align="end">
                <DropdownMenuLabel>My Account</DropdownMenuLabel>
                <DropdownMenuSeparator />
                <DropdownMenuItem onClick={() => navigate("/profile")}>Profile</DropdownMenuItem>
                <DropdownMenuItem onClick={handleLogout}>Logout</DropdownMenuItem>
              </DropdownMenuContent>
            </DropdownMenu>
          )}
        </div>

        {/* MOBILE MENU */}
        {auth && (
          <div className="md:hidden absolute right-4 top-1/2 -translate-y-1/2">
            <DropdownMenu>
              <DropdownMenuTrigger asChild>
                <Button variant="ghost" size="icon"><MenuIcon /></Button>
              </DropdownMenuTrigger>
              <DropdownMenuContent align="end">
                <DropdownMenuItem asChild><Link to="/home">Home</Link></DropdownMenuItem>
                <DropdownMenuItem asChild><Link to="/community">Community</Link></DropdownMenuItem>
                <DropdownMenuItem asChild><Link to="/jobs">Jobs</Link></DropdownMenuItem>
                <DropdownMenuItem asChild><Link to="/friend-requests">Requests</Link></DropdownMenuItem>
                <DropdownMenuSeparator />

                <MobileSearch />

                <DropdownMenuSeparator />
                <DropdownMenuLabel>Notifications</DropdownMenuLabel>
                {notifications.length === 0 && (
                  <DropdownMenuItem disabled>No notifications</DropdownMenuItem>
                )}
                {notifications.map(n => (
                  <DropdownMenuItem key={n.id} onSelect={() => onNotifClick(n)}>
                    {n.message}
                  </DropdownMenuItem>
                ))}
                <DropdownMenuSeparator />

                <DropdownMenuItem asChild><Link to="/messages">Messages</Link></DropdownMenuItem>
                <DropdownMenuItem><ThemeToggle /></DropdownMenuItem>
                <DropdownMenuSeparator />

                <DropdownMenuItem asChild><Link to="/profile">Profile</Link></DropdownMenuItem>
                <DropdownMenuItem onClick={handleLogout}>Logout</DropdownMenuItem>
              </DropdownMenuContent>
            </DropdownMenu>
          </div>
        )}
      </div>
    </header>
  );
};

export default Navbar;