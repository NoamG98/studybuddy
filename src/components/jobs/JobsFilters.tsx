
import { Input } from "@/components/ui/input";
import { 
  Select, 
  SelectContent, 
  SelectItem, 
  SelectTrigger, 
  SelectValue 
} from "@/components/ui/select";

interface JobsFiltersProps {
  searchQuery: string;
  selectedCountry: string;
  selectedRemoteOption: string;
  onSearchChange: (value: string) => void;
  onCountryChange: (value: string) => void;
  onRemoteOptionChange: (value: string) => void;
}

export const JobsFilters = ({
  searchQuery,
  selectedCountry,
  selectedRemoteOption,
  onSearchChange,
  onCountryChange,
  onRemoteOptionChange
}: JobsFiltersProps) => {
  const remoteOptions = ["all", "remote", "hybrid", "on-site"];

  return (
    <div className="mb-8 grid grid-cols-1 md:grid-cols-3 gap-4">
      <div className="md:col-span-1">
        <Input
          placeholder="Search jobs by title, company, or skills..."
          value={searchQuery}
          onChange={(e) => onSearchChange(e.target.value)}
        />
      </div>
      <div>
        <Select
          value={selectedCountry}
          onValueChange={onCountryChange}
        >
          <SelectTrigger>
            <SelectValue placeholder="Filter by country" />
          </SelectTrigger>
          <SelectContent>
            <SelectItem value="all">All Countries</SelectItem>
          </SelectContent>
        </Select>
      </div>
      <div>
        <Select
          value={selectedRemoteOption}
          onValueChange={onRemoteOptionChange}
        >
          <SelectTrigger>
            <SelectValue placeholder="Filter by work type" />
          </SelectTrigger>
          <SelectContent>
            {remoteOptions.map((option) => (
              <SelectItem key={option} value={option}>
                {option === "all" ? "All Types" : 
                  option === "remote" ? "Remote" : 
                  option === "hybrid" ? "Hybrid" : "On-site"}
              </SelectItem>
            ))}
          </SelectContent>
        </Select>
      </div>
    </div>
  );
};
