# Simple MVC Project

A simple ASP.NET Core MVC application built with C# to demonstrate the fundamentals of the MVC architecture.

## Features

* MVC architecture (Model, View, Controller)
* Controller Actions using `IActionResult`
* Displaying Views using `View()`
* Passing data from Controller to View
* Returning text using `Content()`
* Razor syntax and Tag Helpers

## Technologies

* C#
* ASP.NET Core MVC
* .NET 8
* HTML
* Razor

## Project Structure

```text
SimpleMVCProject
├── Controllers
│   └── HomeController.cs
├── Models
│   └── Student.cs
├── Views
│   ├── Home
│   │   ├── Index.cshtml
│   │   └── About.cshtml
│   ├── _ViewImports.cshtml
│   └── _ViewStart.cshtml
└── Program.cs
```

## Getting Started

1. Clone the repository.
2. Open `SimpleMVCProject.sln` in Visual Studio.
3. Restore NuGet packages if needed.
4. Run the project using `Ctrl + F5`.

## Learning Objectives

This project was created to practice the basics of ASP.NET Core MVC, including routing, controller actions, views, models, and action results.
