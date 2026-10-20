# MIO

**MIO — Personal Finance Management System**

MIO is a personal finance management application designed to help users organize their financial activities and track their income and expenses.

## Overview

This repository contains the backend implementation of MIO, built with ASP.NET Core and organized using Clean Architecture principles.

## Tech Stack

- C#
- ASP.NET Core Web API
- Entity Framework Core
- ASP.NET Core Identity
- SQL Server *(if selected as the project database)*

## Architecture

The solution follows Clean Architecture principles, separating business logic from application orchestration and infrastructure concerns.

- **MIO.Domain** — Domain entities, business concepts, domain events, and shared domain abstractions.
- **MIO.Application** — Application-level abstractions and use-case orchestration.
- **MIO.Infrastructure** — Database access, persistence configuration, and infrastructure integrations.
- **MIO.Api** — The HTTP API entry point.

## Project Structure

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

## Getting Started

### Prerequisites

- .NET SDK compatible with the project target framework
- An IDE such as Visual Studio or Visual Studio Code
- SQL Server, if configured as the database provider

### Setup

1. Clone the repository.
2. Open `src/MIO.slnx`.
3. Configure the required application settings and database connection.
4. Restore dependencies and build the solution.
5. Run the `MIO.Api` project.

## Configuration

Configure environment-specific settings locally. Do not commit passwords, credentials, API keys, or production connection strings to source control.

## Testing

Automated tests will be documented here as the test projects and test suites are implemented.

## Project Status

The project is currently under development. Features and setup instructions may evolve as development progresses.
