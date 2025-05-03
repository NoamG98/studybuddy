import { useState } from "react";
import { useNavigate } from "react-router-dom";
import { toast } from "sonner";
import { Input } from "@/components/ui/input";
import { Button } from "@/components/ui/button";
import { userService } from "@/services/api"; 

const GlobalUserSearch = () => {
  const [query, setQuery] = useState("");
  const [isSearching, setIsSearching] = useState(false);
  const navigate = useNavigate();

  const handleSearch = async () => {
    if (!query.trim()) return;
    setIsSearching(true);
    try {

      const users = await userService.getUsers(query, "", "");
      if (users.length === 0) {
        toast.error("No user found with that name");
      } else {
        // Navigate to the found user's profile
        navigate(`/profile/${users[0].id}`);
      }
    } catch (error) {
      toast.error("Error while searching for user");
      console.error("Search error:", error);
    } finally {
      setIsSearching(false);
    }
  };

  const handleKeyPress = (e: React.KeyboardEvent<HTMLInputElement>) => {
    if (e.key === "Enter") {
      e.preventDefault();
      handleSearch();
    }
  };

  return (
    <div className="flex gap-2 w-full">
      <Input
        type="text"
        placeholder="Search for users..."
        value={query}
        onChange={e => setQuery(e.target.value)}
        onKeyDown={handleKeyPress}
        title="Search users"
      />
      <Button onClick={handleSearch} disabled={isSearching}>
        Search
      </Button>
    </div>
  );
};

export default GlobalUserSearch;
