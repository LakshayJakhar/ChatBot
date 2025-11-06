# ChatBotApp - ASP.NET MVC AI ChatBot

![.NET](https://img.shields.io/badge/.NET-7.0-blue)
![C#](https://img.shields.io/badge/C%23-Language-brightgreen)
![SQLite](https://img.shields.io/badge/SQLite-Database-orange)
![License](https://img.shields.io/badge/License-MIT-lightgrey)

**One-liner:**  
An AI-powered chatbot built with ASP.NET MVC and SQLite, integrating the Gemini API to respond to user messages and store chat history.

---

## Table of Contents
1. [Project Overview](#project-overview)  
2. [Features](#features)  
3. [Technologies Used](#technologies-used)  
4. [Setup & Installation](#setup--installation)  
5. [Usage](#usage)  
6. [Folder Structure](#folder-structure)  
7. [Future Improvements](#future-improvements)  
8. [Project Rating & Feedback](#project-rating--feedback)  
9. [Contributing](#contributing)  
10. [License](#license)  

---

## Project Overview
ChatBotApp is a **full-stack ASP.NET MVC web application** that allows users to chat with an AI bot using the Gemini API.  
Conversations are persisted in a **SQLite database** via Entity Framework Core, and the last 10 messages are displayed on the interface.  

This project demonstrates **backend development, API integration, database usage, and MVC architecture** — making it a strong portfolio piece.

---

## Features
- Interactive **AI chatbot** interface  
- Integration with **Gemini API** for AI responses  
- Stores conversation history in **SQLite** using **Entity Framework Core**  
- Displays the **last 10 chat messages** for context  
- Home pages: `Index`, `Privacy`, and `Error` handling  
- **Async API calls** for performance  
- Basic logging via `ILogger<HomeController>`  

---

## Technologies Used
- **ASP.NET MVC 7**  
- **C#**  
- **Entity Framework Core**  
- **SQLite**  
- **Gemini API**  
- **Newtonsoft.Json**  
- **HTML/CSS/Razor views**  

---
1.Setup & Installation

Clone the repository:
git clone https://github.com/LakshayJakhar/ChatBot.git
cd ChatBot/ChatBotApp/ChatBotApp

2.Open the solution in Visual Studio 2022 or newer.

3.Configure the Gemini API key securely:
Add it to appsettings.json:
"GeminiApiKey": "YOUR_API_KEY_HERE"
Or use environment variables for security.

4.Restore NuGet packages and build the solution.

5.Run the application:
Use IIS Express or run from Visual Studio.
Open your browser and navigate to:
https://localhost:5001
