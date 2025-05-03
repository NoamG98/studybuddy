import { useState, useEffect } from "react";
import { Input } from "@/components/ui/input";
import { Card, CardContent } from "@/components/ui/card";
import { Avatar, AvatarImage, AvatarFallback } from "@/components/ui/avatar";
import userService from "@/services/api/userService";
import { User } from "@/models/user";
import { Button } from "@/components/ui/button";

const Search = () => {
  const [query, setQuery] = useState("");
  const [users, setUsers] = useState<User[]>([]);
  const [loading, setLoading] = useState(false);

  useEffect(() => {
    const searchUsers = async () => {
      try {
        setLoading(true);
        const results = await userService.getUsers(query);
        setUsers(results);
      } catch (error) {
        console.error("Search error:", error);
      } finally {
        setLoading(false);
      }
    };

    const delayDebounce = setTimeout(() => {
      if (query.trim()) searchUsers();
      else setUsers([]);
    }, 500);

    return () => clearTimeout(delayDebounce);
  }, [query]);

  return (
    <div className="max-w-2xl mx-auto mt-10 px-4">
      <Input
        type="text"
        placeholder="Search for users by name or email"
        value={query}
        onChange={(e) => setQuery(e.target.value)}
        className="mb-4"
      />

      {loading ? (
        <p>Loading...</p>
      ) : (
        users.map((user) => (
          <Card key={user.id} className="mb-4">
            <CardContent className="p-4 flex items-center justify-between">
              <div className="flex items-center gap-4">
                <Avatar>
                  <AvatarImage src={user.avatarUrl} />
                  <AvatarFallback>
                    {user.firstName?.[0] ?? "U"}
                  </AvatarFallback>
                </Avatar>
                <div>
                  <p className="font-medium">
                    {user.firstName} {user.lastName}
                  </p>
                  <p className="text-sm text-muted-foreground">{user.email}</p>
                </div>
              </div>
              <Button size="sm" variant="outline">
                View Profile
              </Button>
            </CardContent>
          </Card>
        ))
      )}
    </div>
  );
};export default Search;