# StudyBuddy Connect & Careers

**StudyBuddy** is a full-stack web application built with **React/TypeScript**, **Tailwind CSS**, and **.NET 7 Web API**. It enables students, graduates, and employers to connect, share posts, manage friendships, and browse job opportunities in a real-time collaborative environment.

## 📚 Table of Contents

- [Features](#features)  
- [Tech Stack](#tech-stack)  
- [Prerequisites](#prerequisites)  
- [Setup & Installation](#setup--installation)  
- [Database & Migrations](#database--migrations)  
- [Running the Project](#running-the-project)  
- [Common Issues](#common-issues)  
- [Scripts](#scripts)  
- [Environment Configuration](#environment-configuration)  
- [Contributing](#contributing)  
- [About](#about)  

## 🚀 Features

- Secure authentication with JWT  
- Role-based user profiles (Student / Employer / Admin)  
- Real-time notifications with SignalR  
- Friend request system (send, accept, reject)  
- Create, comment, and like posts  
- Browse job listings with advanced filters  
- Responsive design with light/dark mode support  

## 🛠 Tech Stack

- **Frontend**: React, TypeScript, Vite, Tailwind CSS  
- **Backend**: ASP.NET Core 7, Entity Framework Core, SQL Server  
- **Real-time**: SignalR  
- **Other Tools**: Axios, React Query, Sonner (toast notifications)  

## ✅ Prerequisites

Before you start, make sure you have:

- **Node.js** ≥ 18  
- **.NET 7 SDK**  
- **SQL Server** (LocalDB or full version)  
- **Visual Studio 2022** (for backend)  
- **VS Code** (for frontend)  
- **Git**

Optional:

- Postman  
- ESLint / Prettier  

## ⚙️ Setup & Installation

1. Clone the repository:
```bash
git clone https://github.com/NoamG98/studybuddy.git
cd studybuddy
```

2. Install frontend dependencies:
```bash
cd client
npm install
```

3. Install backend dependencies:
```bash
cd ../server
dotnet restore
```

## 🗄️ Database & Migrations

1. In `server/appsettings.json`, ensure your connection string is correctly set:
```json
"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=StudyBuddyDb;Trusted_Connection=True;"
}
```

2. Apply EF Core migrations:
```bash
cd server
dotnet ef database update
```

## ▶️ Running the Project

From the root of the project directory:
```bash
npm run dev
```

- Frontend: http://localhost:8080  
- Backend: http://localhost:5001  

## 🧯 Common Issues

- ❗️ If the project fails to load in Visual Studio:  
  Make sure the `.sln` file is placed under `server/studybuddy/` and not referencing absolute paths.  

- ❗️ If migrations don’t apply:  
  Double-check your SQL Server instance and make sure the connection string matches your local environment.

- ❗️ Ensure ports 5000/5001 are not blocked by firewalls or other apps.

## 🧪 Scripts

```bash
npm run dev       # Start both client & server concurrently
npm run client    # Run frontend only
npm run server    # Run backend only
npm run build     # Build frontend
npm run lint      # Run ESLint
```

## 🌍 Environment Configuration

- **Backend**: `server/appsettings.json` (`ConnectionStrings:DefaultConnection`, JWT, Email settings)  
- **Frontend**: `client/.env`  
  ```env
  VITE_API_BASE_URL=https://localhost:5001/api
  ```

## 🤝 Contributing

1. Fork the repository  
2. Create a new branch: `git checkout -b feature/YourFeature`  
3. Commit your changes  
4. Push and open a pull request  

## 👨‍💻 About

Developed by **Noam Gedalyahu**   
- Frontend: Visual Studio Code  
- Backend: Visual Studio 2022  
- Database: SQL Server / LocalDB  

---

Thank you for using StudyBuddy!
