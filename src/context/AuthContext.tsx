import React, { createContext, useContext, useState, useEffect } from 'react';
import API from '../utils/API.ts';

interface User {
  email: string;
  profilePicture?: string;
  firstName?: string;
  lastName?: string;
}

interface AuthContextType {
  user: User | null;
  login: (token: string, userData: User) => void;
  logout: () => void;
}

const AuthContext = createContext<AuthContextType | undefined>(undefined);

export const AuthProvider: React.FC<{ children: React.ReactNode }> = ({ children }) => {
  const [user, setUser] = useState<User | null>(null);

  useEffect(() => {
    const token = localStorage.getItem('jwtToken');
    const email = localStorage.getItem('userEmail');
    if (token && email) {
      API.get(`/Users/currentProfilePicture`, { params: { email } })
        .then((response) => {
          const { profilePictureUrl, firstName, lastName } = response.data;
          setUser({ email, profilePicture: profilePictureUrl, firstName, lastName });
        })
        .catch((err) => console.error('Failed to fetch user data:', err));
    }
  }, []);

  const login = (token: string, userData: User) => {
    // שמירה של הטוקן ואימייל המשתמש
    localStorage.setItem('jwtToken', token);
    localStorage.setItem('userEmail', userData.email);
    setUser(userData);
  };

  const logout = () => {
    // מחיקה של הטוקן ואימייל המשתמש בעת התנתקות
    localStorage.removeItem('jwtToken');
    localStorage.removeItem('userEmail');
    setUser(null);
  };

  return (
    <AuthContext.Provider value={{ user, login, logout }}>
      {children}
    </AuthContext.Provider>
  );
};

export const useAuth = () => {
  const context = useContext(AuthContext);
  if (!context) {
    throw new Error('useAuth must be used within an AuthProvider');
  }
  return context;
};
