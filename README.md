# Selenium NUnit Project

This project is a sample **C# Selenium automation framework** using **NUnit**.  



## 📦 Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- Google Chrome installed

# To fetch dependecies 
`dotnet restore`

# To run tests

`dotnet test`

# To create a new project use below commands in bash

## This creates a folder with an NUnit test project.

`dotnet new nunit -n SeleniumNUnitProject`


## Add Selenium WebDriver packages via Terminal from project folder

```
dotnet add package Selenium.WebDriver
dotnet add package Selenium.Support
dotnet add package Selenium.WebDriver.ChromeDriver