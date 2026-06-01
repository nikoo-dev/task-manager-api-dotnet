# Task Manager API

A RESTful API built with **ASP.NET Core 8** and **C#** for managing tasks — featuring full CRUD, SQLite persistence, input validation, status filtering, and interactive Swagger UI.

## Tech Stack

| | |
|---|---|
| Framework | ASP.NET Core 8 |
| Language | C# |
| ORM | Entity Framework Core |
| Database | SQLite |
| Docs | Swagger / Swashbuckle |

## Features

- Full CRUD — Create, Read, Update, Delete tasks
- Real database persistence with EF Core + SQLite (auto-migration on startup)
- Input validation — required fields, max length enforced
- Filter tasks by completion status (`?isCompleted=true/false`)
- Interactive Swagger UI for testing all endpoints

## API Endpoints

| Method | Endpoint | Description |
|--------|----------|-------------|
| GET | `/api/tasks` | Get all tasks (supports `?isCompleted=true/false`) |
| GET | `/api/tasks/{id}` | Get task by ID |
| POST | `/api/tasks` | Create a new task |
| PUT | `/api/tasks/{id}` | Update a task |
| DELETE | `/api/tasks/{id}` | Delete a task |

## Getting Started

```bash
# Clone the repository
git clone https://github.com/nikoo-dev/task-manager-api-dotnet.git

# Navigate to the project
cd task-manager-api-dotnet/TaskManagerAPI

# Run
dotnet run
```

Open Swagger UI at: `http://localhost:5113/swagger`

## Example Request

```json
POST /api/tasks
{
  "title": "Learn ASP.NET Core",
  "description": "Build a REST API with EF Core and SQLite",
  "isCompleted": false
}
```

## Validation Rules

- `title` — required, max 100 characters
- `description` — optional, max 500 characters

## Roadmap

- [ ] JWT authentication
- [ ] Task priority levels (Low / Medium / High)
- [ ] xUnit unit tests
- [ ] Azure deployment

## Author

**Niko** · [github.com/nikoo-dev](https://github.com/nikoo-dev)  
Available for freelance .NET backend work — [Fiverr](https://www.fiverr.com/niko23227)
