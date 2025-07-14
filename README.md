# StudyBuddy Connect & Careers

StudyBuddy is a full-stack web application built with **React/TypeScript**, **Tailwind CSS**, and **.NET Core**. It allows students, graduates, and employers to connect, share posts, and manage friend requests and job opportunities.

---

## Table of Contents

- [Features](#features)  
- [Tech Stack](#tech-stack)  
- [Prerequisites](#prerequisites)  
- [Setup & Installation](#setup--installation)  
- [Database & Migrations](#database--migrations)  
- [Running the Project](#running-the-project)  
- [Scripts](#scripts)  
- [Environment Configuration](#environment-configuration)  
- [Contributing](#contributing)  
- [About](#about)  

---

## Features

- User authentication & role-based profiles  
- Friend requests (send, accept, reject)  
- Real-time notifications via SignalR  
- Create, edit, delete posts with comments & likes  
- Job listings & search filters  
- Dark/light theme toggle  

## Tech Stack

- **Frontend**: React, TypeScript, Vite, Tailwind CSS  
- **Backend**: .NET 7 Web API, EF Core, SQL Server  
- **Real-time**: SignalR  
- **Other Tools**: Axios, React Query, Sonner (toasts)  

## Prerequisites

- **Node.js** ≥ 18 & **npm**  
- **.NET 7 SDK**  
- **SQL Server** (LocalDB or full SQL Server)  
- **Visual Studio 2022** (backend)  
- **VS Code** (frontend)  

Optional:

- **Git**  
- **Postman**  
- **ESLint**, **Prettier**  

## Setup & Installation

1. Clone the repo:  
   ```bash
+ git clone https://github.com/NoamG98/studybuddy.git
+ cd studybuddy
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

## Database & Migrations

1. Configure the connection string in `server/appsettings.json` or as env var `ConnectionStrings__DefaultConnection`:
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

## Running the Project

From the project root, run:
```bash
npm run dev
```
- **Client**: http://localhost:8080  
- **Server**: http://localhost:5001  

## Scripts

```bash
npm run dev       # start both client & server
npm run client    # frontend only
npm run server    # backend only
npm run build     # build frontend
npm run lint      # run ESLint
```

## Environment Configuration

- **Backend**: `server/appsettings.json` (`ConnectionStrings:DefaultConnection`, JWT settings)  
- **Frontend**: `client/.env` (`VITE_API_BASE_URL=https://localhost:5001/api`)

## Contributing

1. Fork  
2. Create branch: `git checkout -b feature/YourFeature`  
3. Make changes & commit  
4. Push & PR  

## About

Developed by **Noam Gedalyahu.** with help from **ChatGPT**.  
- Frontend: VS Code  
- Backend: Visual Studio 2022  
- Database: SQL Server / LocalDB  

---

Thank you for using StudyBuddy!
