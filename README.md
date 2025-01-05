# Employee Management Software - Backend Documentation

## Table of Contents
1. [Overview](#overview)
2. [Technologies Used](#technologies-used)
3. [Project Setup](#project-setup)
4. [Database Design (JSON)](#database-design-json)
5. [Microservices Architecture](#microservices-architecture)
6. [JWT Token Authentication](#jwt-token-authentication)
7. [API Endpoints](#api-endpoints)
8. [Running the Application](#running-the-application)
9. [Testing the API](#testing-the-api)

---

## Overview

This backend serves as the core part of the **Employee Management Software**, built using **ASP.NET Core 8 (C#)**. The backend is responsible for managing employee information and is designed with a **Microservices Architecture** to ensure modularity, scalability, and ease of maintenance.

### Key Features:
- **Database**: In this prototype, a **JSON object** is used as a lightweight database for storing employee data. This can be easily swapped with an actual database (e.g., SQL Server, MongoDB) when the project moves to production.
- **Microservices**: The system is designed using a **microservices architecture**. Each service is independent and communicates over HTTP-based APIs.
- **Authentication**: **JWT Token Authentication** is used to secure the API endpoints, ensuring only authenticated users can access protected resources.

---

## Technologies Used

The project utilizes the following technologies:

- **ASP.NET Core 8 (C#)**: Framework for building RESTful APIs.
- **JWT (JSON Web Token)**: For securing API endpoints with token-based authentication.
- **Microservices Architecture**: A modular design for decoupling functionality into smaller, independently deployable services.
- **JSON**: Used for data representation (in-memory database for simplicity).
- **Swagger**: For API documentation and interactive testing of the endpoints.

---

## Project Setup

### Prerequisites
Before you begin, ensure you have the following installed:

- **.NET SDK 8.x**: Download and install [from Microsoft](https://dotnet.microsoft.com/download/dotnet).
- **Visual Studio Code or Visual Studio**: A text editor or an IDE for development. You can download Visual Studio [here](https://visualstudio.microsoft.com/).
- **Postman** or similar API testing tool: To test the API endpoints.

### Clone the Repository

Clone the repository to your local machine using the following command:

```bash
git clone https://github.com/NIR456/RSystem_backend.git
