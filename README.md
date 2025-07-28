# MyWebApi

A C# Web API project built for learning .NET development fundamentals.

## Getting Started

### Prerequisites
- .NET 8.0 SDK or later
- Visual Studio 2022 or VS Code

### Installation
```bash
git clone <repository-url>
cd MyWebApi
dotnet restore
dotnet run
```

The API will be available at `https://localhost:7000` (or the port shown in console).

## API Endpoints

### Example Endpoints
- `GET /api/values` - Get all values
- `GET /api/values/{id}` - Get value by ID
- `POST /api/values` - Create new value
- `PUT /api/values/{id}` - Update value
- `DELETE /api/values/{id}` - Delete value

## Learning Objectives

This project covers:
- ✅ RESTful API design
- ✅ HTTP methods (GET, POST, PUT, DELETE)
- ✅ Routing and controllers
- ✅ Model binding and validation
- ✅ Dependency injection
- ✅ Swagger/OpenAPI documentation

## Project Structure
```
MyWebApi/
├── Controllers/     # API controllers
├── Models/         # Data models
├── Services/       # Business logic
└── Program.cs      # Application entry point
```

## Technologies Used
- ASP.NET Core Web API
- Swagger UI for API documentation

## Resources
- [ASP.NET Core Documentation](https://docs.microsoft.com/en-us/aspnet/core/)
- [Web API Tutorial](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api)
