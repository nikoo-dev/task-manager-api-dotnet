# Task Manager API

A RESTful API built with **ASP.NET Core 8** and **C#** for managing tasks.

## Tech Stack
- ASP.NET Core 8
- C#
- Entity Framework Core
- SQLite
- Swagger / Swashbuckle

## Features
- ✅ Full CRUD operations (Create, Read, Update, Delete)
- ✅ Real database persistence with SQLite
- ✅ Input validation (required fields, max length)
- ✅ Filter tasks by completion status
- ✅ Swagger UI for interactive API testing

## Endpoints

| Method | URL | Description |
|--------|-----|-------------|
| GET | /api/tasks | Get all tasks (supports ?isCompleted=true/false) |
| GET | /api/tasks/{id} | Get task by ID |
| POST | /api/tasks | Create new task |
| PUT | /api/tasks/{id} | Update task |
| DELETE | /api/tasks/{id} | Delete task |

## How to Run

1. Clone the repository
```bash
git clone https://github.com/5nikoo-1/task-manager-api-dotnet.git
```

2. Navigate to the project
```bash
cd task-manager-api-dotnet/TaskManagerAPI
```

3. Run the project
```bash
dotnet run
```

4. Open Swagger UI
```
http://localhost:5113/swagger
```

## Example Request

Create a new task:
```json
{
  "title": "Learn C#",
  "description": "Build a REST API with ASP.NET Core",
  "isCompleted": false
}
```

## Validation Rules
- Title is **required**
- Title max length: **100 characters**
- Description max length: **500 characters**

## Future Improvements
- Add user authentication with JWT
- Add task priority (Low / Medium / High)
- Deploy to Azure
- Add unit tests with xUnit