# E-Commerce-SaaS 

A SaaS project that allows small merchants to create a minimalistic and simplistic store quickly. The store creation and management process are easy and quick.

## Demo
<img width="907" alt="shopperDemo" src="https://user-images.githubusercontent.com/61489549/206221106-4bb8b585-9962-467b-8f12-62d9efdebc26.PNG">

## Installation

1) Clone the project
```bash
  https://github.com/fa93/E-Commerce-SaaS.git
```
2) Run the file with extension ` .Sln ` on Visual Studio

3) Set the `DefaultConnection` in `appsettings.json` file 
```bash
"ConnectionStrings": {
    "DefaultConnection": ""
  },
```

4) Now, Update the migrations by running the following command on ``` Package Manager Console ```
```bash
  dotnet ef database update --project Shoppers.Web --context StorageDbContext
```
⚠️ Must install ` Microsoft Visual Studio `, ` Microsoft SQL Server` and `SQL Server Management Studio` on your Mechine

## Features
- Create Store and setup
- Social media accounts Login
-	Products and categories
-	Inventory
- Role based authorization and authentication

## Tech Stack

**Backend:** ASP.NET Core 6, Entity Framework core

**Server:**  Microsoft SQL Server

**Logger:** Serilog

**Dependency Injection:** Autofac

**Others:** MailKit (Email Framework)

**Design Patterns:** Repository & Unit of Work

**Architecture:** Layered Architecture (UI, Business Logic & Data Access Layer)
