import React, { useState, useEffect } from "react";
import { useNavigate } from "react-router-dom";
import axios from "axios";
import "../styles/Register.css";

interface StudyField {
  id: number;
  name: string;
}

const RegisterPage: React.FC = () => {
  const navigate = useNavigate();
  const [formData, setFormData] = useState({
    firstName: "",
    lastName: "",
    email: "",
    password: "",
    studyField: "",
    birthday: "",
    country: "",
  });

  const [studyFields, setStudyFields] = useState<StudyField[]>([]);
  const [error, setError] = useState<string | null>(null);

  // Fetch study fields from the API
  useEffect(() => {
    const fetchStudyFields = async () => {
      try {
        const response = await axios.get("http://localhost:5000/api/StudyFields");
        setStudyFields(response.data);
      } catch (err) {
        console.error("Error fetching study fields:", err);
        setError("Failed to fetch study fields. Please try again later.");
      }
    };

    fetchStudyFields();
  }, []);

  // Submit the registration form
  const handleSubmit = async (e) => {
    e.preventDefault();
    try {
        const response = await axios.post(
            "http://localhost:5000/api/Users/register",
            formData,
            {
                headers: {
                    "Content-Type": "application/json"
                }
            }
        );
        if (response.status === 200) {
            navigate("/registration-success");
        } else {
            throw new Error("Failed to register");
        }
    } catch (err) {
      console.error("Error registering user:", err);
      setError("Failed to register. Please try again later.");
    }
};

  return (
    <div className="form-container">
      <h1 className="form-title">Register</h1>
      {error && <p className="error-message">{error}</p>}
      <form onSubmit={handleSubmit}>
        <div className="form-group">
          <label htmlFor="firstName">First Name:</label>
          <input
            type="text"
            id="firstName"
            autoComplete="given-name"
            value={formData.firstName}
            onChange={(e) =>
              setFormData({ ...formData, firstName: e.target.value })
            }
            required
          />
        </div>
        <div className="form-group">
          <label htmlFor="lastName">Last Name:</label>
          <input
            type="text"
            id="lastName"
            autoComplete="family-name"
            value={formData.lastName}
            onChange={(e) =>
              setFormData({ ...formData, lastName: e.target.value })
            }
            required
          />
        </div>
        <div className="form-group">
          <label htmlFor="email">Email:</label>
          <input
            type="email"
            id="email"
            autoComplete="email"
            value={formData.email}
            onChange={(e) =>
              setFormData({ ...formData, email: e.target.value })
            }
            required
          />
        </div>
        <div className="form-group">
          <label htmlFor="password">Password:</label>
          <input
            type="password"
            id="password"
            autoComplete="new-password"
            value={formData.password}
            onChange={(e) =>
              setFormData({ ...formData, password: e.target.value })
            }
            required
          />
        </div>
        <div className="form-group">
          <label htmlFor="studyField">Select Your Study Field:</label>
          <select
            id="studyField"
            value={formData.studyField}
            onChange={(e) =>
              setFormData({ ...formData, studyField: e.target.value })
            }
            required
          >
            <option value="">Select a study field</option>
            {studyFields.map((field) => (
              <option key={field.id} value={field.name}>
                {field.name}
              </option>
            ))}
          </select>
        </div>
        <div className="form-group">
          <label htmlFor="birthday">Date of Birth:</label>
          <input
            type="date"
            id="birthday"
            value={formData.birthday}
            onChange={(e) =>
              setFormData({ ...formData, birthday: e.target.value })
            }
            required
          />
        </div>
        <div className="form-group">
          <label htmlFor="country">Country:</label>
          <input
            type="text"
            id="country"
            value={formData.country}
            onChange={(e) =>
              setFormData({ ...formData, country: e.target.value })
            }
            required
          />
        </div>
        <button className="form-button" type="submit">
          Register
        </button>
      </form>
    </div>
  );
};

export default RegisterPage;
