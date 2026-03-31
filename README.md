# Full Stack Web Application (ASP.NET Core MVC)

## 📌 Description
This is a full stack web application built using ASP.NET Core MVC for the backend and HTML5, CSS, and JavaScript for the frontend.  
The application follows the MVC architectural pattern and demonstrates how the frontend interacts with the backend through controllers, views, and server-side rendering, along with client-side JavaScript for dynamic behavior.

## 🚀 Features
- User interface built with HTML5, CSS, and JavaScript
- ASP.NET Core MVC architecture
- Views rendered using Razor
- CRUD operations
- Database integration using Entity Framework
- Client-server communication using HTTP requests (Fetch/AJAX where applicable)

## 🛠 Technologies Used

### Backend:
- ASP.NET Core MVC
- C#
- Entity Framework
- SQL Server

### Frontend:
- HTML5
- CSS
- JavaScript (Fetch API / AJAX)
- Razor Views

## 📁 Project Structure
- Controllers → Handle requests and return Views or data
- Models → Define application data and entities
- Views → Razor pages (UI layer)
- wwwroot → Static files (CSS, JavaScript, images)
- appsettings.json → Application configuration
- Program.cs → Application entry point

## 🔄 How It Works
1. The user sends a request through the browser
2. The request is handled by an MVC Controller
3. The controller processes the request and interacts with the database if needed
4. The controller returns a View (Razor) or data
5. The View is rendered and displayed to the user
6. JavaScript may be used to send additional asynchronous requests to the server

## ▶️ How to Run
1. Open the project in Visual Studio
2. Restore NuGet packages
3. Configure the database connection string in `appsettings.json`
4. Run the application using IIS Express or Kestrel
5. Access the application via the browser

## 📌 Purpose
This project was developed to practice full stack development using ASP.NET Core MVC, understand the MVC pattern, and build a complete application with frontend and backend integration.

---

**Author:** Osama Sawalha
