# MIO Backend

**MIO — Personal Finance Management System**

## Overview

MIO is a personal finance management application built with a backend architecture based on Clean Architecture principles.

The solution separates domain concepts, application-level abstractions, API configuration, and infrastructure concerns.

## Architecture

### MIO.Api

The entry point for HTTP requests and API configuration.

### MIO.Application

Contains application-level abstractions and the foundation for implementing application use cases.

Current foundation:

- `IAppDbContext` — Abstraction for database access through Entity Framework Core.

### MIO.Domain

Contains the foundational domain abstractions:

- `Entity` and `AuditableEntity`.
- Domain event abstractions.
- Result Pattern and structured error abstractions.

### MIO.Infrastructure

Contains infrastructure implementations and persistence configuration.

Current foundation:

- `AppDbContext` — Entity Framework Core context integrated with ASP.NET Core Identity.
- Model configuration discovery through `ApplyConfigurationsFromAssembly`.

## Technology Stack

- C#
- .NET
- ASP.NET Core Web API
- Entity Framework Core
- ASP.NET Core Identity
- Clean Architecture

The database provider and remaining dependencies should be documented once their configuration is finalized.

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

## Development Status

- [x] Initialize the Clean Architecture solution structure.
- [x] Establish the domain foundation and Result Pattern.
- [x] Introduce the application database-context abstraction.
- [x] Establish the initial EF Core context in Infrastructure.
- [ ] Configure the database provider and connection settings.
- [ ] Implement application use cases.
- [ ] Add database migrations and automated tests.

## Getting Started

### Prerequisites

- The .NET SDK compatible with the project target framework.
- A compatible IDE or the .NET CLI.

### Setup

1. Clone the repository.
2. Open `src/MIO.slnx`.
3. Restore dependencies.
4. Configure the required database settings locally.
5. Build the solution.

Database creation, migrations, and API execution instructions will be added once their configuration is complete.

## Configuration and Security

Do not commit passwords, API keys, production credentials, or sensitive connection strings.

Keep environment-specific settings outside source control and document required configuration variables without including their secret values.

## Testing

Automated test instructions will be added as test projects and test suites are implemented.

## Project Status

MIO is under active development. This README documents the current backend foundation and will evolve as features are implemented.
