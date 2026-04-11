# Task Manager API

A RESTful API built with **ASP.NET Core 8** and **C#**.

## Features
- Create, read, update and delete tasks
- Swagger UI for testing endpoints
- Clean controller structure

## Tech Stack
- ASP.NET Core 8
- C#
- Swagger / Swashbuckle

## Endpoints
| Method | URL | Description |
|--------|-----|-------------|
| GET | /api/task | Get all tasks |
| GET | /api/task/{id} | Get task by ID |
| POST | /api/task | Create new task |
| PUT | /api/task/{id} | Update task |
| DELETE | /api/task/{id} | Delete task |

## How to Run
```bash
dotnet run
```
Then open: http://localhost:5113/swagger