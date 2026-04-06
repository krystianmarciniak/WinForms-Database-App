# Firma – Business Management System (WinForms)

![Build Status](https://github.com/krystianmarciniak/WinForms-Database-App/actions/workflows/build.yml/badge.svg)
![.NET Framework](https://img.shields.io/badge/.NET-Framework%204.8-blue)
![Platform](https://img.shields.io/badge/platform-Windows-lightgrey)
![Database](https://img.shields.io/badge/database-SQL%20Server%20LocalDB-green)
![Status](https://img.shields.io/badge/status-Completed-success)

Desktop application written in **C# (Windows Forms)** for managing company data, employees, contractors, and sales invoices.

---

## Demo

![App Demo](./Firma.gif)

---

## Key Features

### Data Management
- manage **Clients**
- manage **Employees**
- manage **Contractors (Companies)**
- full CRUD operations

### Invoice System
- create and manage **Sales Invoices**
- assign invoices to:
  - contractor
  - employee
- track payment status

### Filtering & Search
- show **unpaid invoices**
- filter invoices by contractor
- global search across multiple entities

### UI / UX
- color-coded invoices:
  - 🟢 paid
  - 🔴 unpaid
- structured layout with clear sections
- responsive DataGridView
- intuitive user interaction

### Persistence
- automatic saving to database
- data persists between sessions

---

## System Design

The application models a simplified company workflow:

- **Client** → individual customer  
- **Contractor** → company (NIP, address)  
- **Employee** → handles transactions  
- **Invoice** → linked to contractor and employee  

### Relationships
- Invoice → Contractor (FK)
- Invoice → Employee (FK)

---

## Technologies

- C#
- .NET Framework 4.8
- Windows Forms
- SQL Server LocalDB
- ADO.NET (DataSet + TableAdapter)
- Visual Studio

---

## Database

Local database file:
Firma.mdf
|DataDirectory| 

Ensures portability across machines.

---

## Project Structure

- `Form1.cs` – main logic and UI handling
- `FirmaDataSet.xsd` – dataset and adapters
- `App.config` – connection string
- `Firma.mdf` – database

---

## Purpose

This project demonstrates:

- desktop application development in WinForms  
- working with relational data  
- implementing business logic  
- building user-friendly interfaces  

---

## Future Improvements

- user authentication system (login & roles)
- reporting module (charts, summaries)
- export to CSV / Excel
- notifications for unpaid invoices
- migration to web version (ASP.NET / React)
- separation of logic (MVC / MVVM pattern)

---

## Installation

1. Clone repository:
```bash
git clone https://github.com/krystianmarciniak/WinForms-Database-App.git