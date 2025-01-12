import React, { useState } from "react";

const UserForm: React.FC = () => {
  const [name, setName] = useState("");
  const [email, setEmail] = useState("");
  const [fieldOfStudy, setFieldOfStudy] = useState("");

  const handleSubmit = (e: React.FormEvent) => {
    e.preventDefault();
    console.log("User details:", { name, email, fieldOfStudy });
    // Add user creation/update API call here
  };

  return (
    <form onSubmit={handleSubmit}>
      <h1>Create/Update User</h1>
      <input
        type="text"
        placeholder="Name"
        value={name}
        onChange={(e) => setName(e.target.value)}
      />
      <input
        type="email"
        placeholder="Email"
        value={email}
        onChange={(e) => setEmail(e.target.value)}
      />
      <input
        type="text"
        placeholder="Field of Study"
        value={fieldOfStudy}
        onChange={(e) => setFieldOfStudy(e.target.value)}
      />
      <button type="submit">Submit</button>
    </form>
  );
};

export default UserForm;
