# MIO Backend

**MIO — Personal Finance Management System**

## Overview

MIO is a personal finance management application designed to help users organize and manage their financial activities.

This repository contains the backend solution, structured using Clean Architecture principles to promote separation of concerns, maintainability, and testability.

## Solution Structure

```text
MIO/
├── src/
│   ├── MIO.Api/
│   ├── MIO.Application/
│   ├── MIO.Domain/
│   ├── MIO.Infrastructure/
│   └── MIO.slnx
├── tests/
├── .gitignore
└── README.md
```

## Architecture Overview

The solution is organized into four main projects:

- **MIO.Api** — The entry point for HTTP requests and API configuration.
- **MIO.Application** — The application layer, responsible for application-level abstractions and use cases.
- **MIO.Domain** — The core domain layer, containing domain models and business rules.
- **MIO.Infrastructure** — The infrastructure layer, responsible for persistence and external technical integrations.

## Technology Stack

- C#
- .NET
- ASP.NET Core Web API
- Clean Architecture

Additional technologies and dependencies will be documented as they are introduced.

## Development Status

The solution structure has been initialized. Domain logic, application abstractions, and infrastructure configuration are being developed incrementally.

## Getting Started

1. Install the .NET SDK compatible with the project target framework.
2. Clone the repository.
3. Open `src/MIO.slnx` using a compatible IDE or the .NET CLI.
4. Restore dependencies and build the solution.

Application-specific configuration and execution instructions will be added as the backend implementation progresses.
