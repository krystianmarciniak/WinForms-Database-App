![Build](https://github.com/krystianmarciniak/WinForms-Database-App/actions/workflows/build.yml/badge.svg)

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

## Project structure

- `Form1.cs` – main application logic
- `FirmaDataSet.xsd` – dataset and table adapter
- `App.config` – database connection settings
- `Firma.mdf` – local database file

## Status

Project builds successfully and stores records in LocalDB.