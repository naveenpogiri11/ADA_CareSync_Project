# 💡 CareSync – Smart Appointment Scheduling System

A full-stack ASP.NET Core MVC application for managing doctor appointments, built with clean architectural layering and hosted on Azure.

🔗 **Live Demo**: [CareSync App](https://myappdemo123-f4deahbgcae9f4aw.canadacentral-01.azurewebsites.net/)  
📦 **GitHub Repo**: [ADA_CareSync_Project](https://github.com/naveenpogiri11/ADA_CareSync_Project)

---

## 🏗️ Architecture Overview

- **MVC Pattern**: Models (EF Core), Views (Razor), Controllers (Routing/Logic)
- **Service Layer**: `DoctorService` handles caching and business logic
- **EF Core**: Handles DB interactions using `CareSyncDbContext`
- **Azure Hosted**: App Service + Azure SQL; configs in `appsettings.json`

---

## 🌐 API Endpoints

| Method | Endpoint                | Description                          |
|--------|-------------------------|--------------------------------------|
| GET    | `/Appointment/Create`   | Loads appointment booking form       |
| POST   | `/Appointment/Create`   | Submits a new appointment            |
| GET    | `/Appointment/Index`    | Lists all appointments               |
| GET    | `/Home/Chart`           | Loads chart data for appointments    |
| GET    | `/Account/Login` / `/Logout` | Handles login/logout (if applicable) |

---

## 🧩 Data Model (ERD)

![ERD](https://github.com/user-attachments/assets/0abd71d1-bca4-4c0f-88fa-19bbe91f549d)

---

## 🔁 CRUD Implementation

- **Create**: Users can book appointments with dynamically loaded doctor lists.
- **Read**: Appointments are listed using `AppointmentDisplayViewModel`.
- **Update**: (Planned or partial) Update existing appointment data.
- **Delete**: (If implemented) Remove appointments.

---

## ⚙️ Notable Technical Challenges & Solutions

- **Azure Integration**:  
  Set up App Service and SQL Database hosting with secure connection strings.

- **Git Collaboration**:  
  Used GitHub for version control and team collaboration, resolving merges and maintaining commit hygiene.

- **Chart Integration**:  
  Matched EF Core query data with Chart.js input formats to visualize trends.

- **Form Validation**:  
  Robust backend and frontend validation for appointment creation.

- **External API Mapping**:  
  Doctor data was fetched and cached using a service layer, ensuring schema compatibility.

- **Responsive Layout Tuning**:  
  Razor views and CSS were refined for cross-device compatibility.

---

## 🚀 Future Enhancements

- User authentication and login for patients
- Calendar-based scheduling with real-time slot updates
- Doctor filtering by city, gender, or facility
- Doctor profile image upload support

