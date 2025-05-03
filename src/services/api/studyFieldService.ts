import api from "../api";

export const studyFieldService = {
  getStudyFields: async (): Promise<string[]> => {

    const { data } = await api.get<Array<{ id: string; name: string }>>(
      "/api/StudyFields"
    );
    return data.map((sf) => sf.name);
  },
};

export default studyFieldService;