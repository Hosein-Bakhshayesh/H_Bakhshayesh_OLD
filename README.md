# Personal Resume Website (Earlier Version)

The first version of my personal resume website: a public resume page plus an admin panel for managing its content.

> **Status:** archived. It is being replaced by a new version of the site and is not maintained.

## Features

**Public site**
- Profile and basic information
- Work experience, skills and documents/certificates
- Contact form

**Admin panel**
- Edit profile information
- Add, edit and remove experiences, skills and documents (with image upload)
- Read messages sent through the contact form

## Tech stack

- **.NET 7**, ASP.NET Core Web API, **Blazor WebAssembly** (hosted)
- **Entity Framework Core** with **SQL Server**
- AutoMapper
- Bootstrap (RTL)

## Architecture

```
H_Bakhshayesh/
├── Client/                   Blazor WebAssembly UI (public pages + admin panel)
├── Server/                   ASP.NET Core host and API controllers
└── Shared/                   View models shared by client and server
H_BakhshayeshModels/          EF Core entities and DbContext
H_BakhshayeshRepository/      Generic and entity-specific repositories
H_BakhshayeshServices/        Business logic services
```

Requests flow **Blazor client → API controller → service → repository → EF Core → SQL Server**.
