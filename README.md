# WinForms Database App

![Build Status](https://github.com/krystianmarciniak/WinForms-Database-App/actions/workflows/build.yml/badge.svg)

Simple Windows Forms application with SQL Server database for managing company clients.

# Firma – WinForms CRUD Application

Desktop application written in C# using Windows Forms and SQL Server LocalDB.

## Features

- display clients in DataGridView
- add new clients
- edit existing clients
- delete clients
- automatic saving to database
- persistent data after restart

## Technologies

- C#
- .NET Framework
- Windows Forms
- SQL Server LocalDB
- Visual Studio

## Database

The application uses a local SQL Server database file (`Firma.mdf`).

For portability, the project is configured to load the database from the application directory using `|DataDirectory|`.

Recommended environment:
- .NET Framework 4.8
- SQL Server LocalDB

## Project structure

- `Form1.cs` – main application logic
- `FirmaDataSet.xsd` – dataset and table adapter
- `App.config` – database connection settings
- `Firma.mdf` – local database file

## Status

Project builds successfully and stores records in LocalDB.