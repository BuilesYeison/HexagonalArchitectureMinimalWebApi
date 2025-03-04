# Hexagonal Architecture Minimal API

## Introduction
This project is a **Minimal API** built using **Hexagonal Architecture**. The primary goal is to provide a clean and maintainable foundation for lightweight APIs with specific responsibilities, such as email sending for example. This architecture ensures decoupling between the business logic and infrastructure, improving testability and scalability.

## Technologies Used
- **.NET 8 Minimal API**
- **Hexagonal Architecture (Ports & Adapters)**
- **Dependency Injection**
- **Swagger/OpenAPI**
- **Exception Handling Middleware**
- **DTOs (Data Transfer Objects)**

---

## Project Structure

```
HexagonalArchitectureApp
├───Application
│   ├───DTO
│   ├───Ports
│   │   ├───Repositories
│   │   └───Services
│   ├───UseCases
│   ├───Wrappers
│   └───DependencyInjection.cs
│
├───Domain
│   ├───Entities
│   ├───Enums
│   ├───Exceptions
│   └───ValueObjects
│
├───Infrastructure
│   ├───Adapters
│   │   ├───Repositories
│   │   └───Services
│   ├───Persistence (if needed in future)
│   ├───Logging
│   └───DependencyInjection.cs
│
└───WebAPI
    ├───Middleware
    ├───Endpoints (optional modular routes)
    ├───DependencyInjection
    ├───Controllers (if necessary)
    ├───Properties
    ├───Program.cs
    └───appsettings.json
```

---

## Explanation of Layers

### **1. Application Layer** (Use Cases & DTOs)
- Contains **Use Cases** that implement business logic.
- Defines **Ports (Interfaces)** for communication with Infrastructure.
- Uses **DTOs** for input/output transformations.
- Implements **Wrappers** for response consistency.

### **2. Domain Layer** (Core Business Logic)
- Defines **Entities** and **Value Objects**.
- Contains **Enums** and **Custom Exceptions**.
- Free of dependencies on external libraries.

### **3. Infrastructure Layer** (Adapters & External Services)
- Implements **Adapters** for database and external APIs.
- Handles **Email Services** (e.g., SendGrid, Twilio).
- Manages **Logging & Persistence** (if necessary).

### **4. WebAPI Layer** (Minimal API Endpoints)
- Configures the **Minimal API** and routes.
- Implements **Middleware for Exception Handling**.
- Integrates **Dependency Injection** for application services.
- Exposes **Swagger/OpenAPI** documentation.

---

## Future Improvements

🔹 **FluentValidation** - Implement request validation for DTOs.
🔹 **CQRS & Mediator** - Introduce `MediatR` for command-query separation (if needed).
🔹 **Unit Tests & Integration Tests** - Ensure business logic correctness.
🔹 **Database Integration** - Store email logs in a database.
🔹 **Authentication & Authorization** - Add JWT or OAuth for security.
🔹 **Event-Driven Architecture** - Use background processing for email dispatching.

---

## Contribution Guidelines
Feel free to contribute by creating a **pull request** or submitting **issues** for bug reports or feature requests.

---

## License
This project is licensed under **MIT License**.
