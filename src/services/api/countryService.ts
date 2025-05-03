import api from "../api";

export const countryService = {
  getCountries: async (): Promise<string[]> => {
    const { data } = await api.get<string[]>("/api/Countries");
    return data;
  },
};

export default countryService;
