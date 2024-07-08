# Sample JWT Project

This repository contains a sample .NET 8.0 project demonstrating JWT authentication, utilizing various packages to set up a robust and secure authentication system. The project also includes Docker support for easy deployment.

## Technologies Used

- **.NET 8.0**
- **JWT Authentication**
- **Entity Framework Core**
- **PostgreSQL**
- **Swagger for API documentation**
- **Docker**

## Project Setup

### Prerequisites

- .NET 8.0 SDK
- Docker (for containerization)
- PostgreSQL (for database)

### Configuration

The project uses User Secrets to manage sensitive information. Make sure to set up the user secrets as required.

### Packages

The following NuGet packages are used in this project:

- `Asp.Versioning.Mvc` (8.1.0)
- `Microsoft.AspNetCore.Authentication.JwtBearer` (8.0.6)
- `Microsoft.AspNetCore.Identity.EntityFrameworkCore` (8.0.6)
- `Microsoft.EntityFrameworkCore` (8.0.6)
- `Microsoft.EntityFrameworkCore.Design` (8.0.6)
- `Microsoft.IdentityModel.Tokens` (7.6.2)
- `Microsoft.VisualStudio.Azure.Containers.Tools.Targets` (1.21.0)
- `Npgsql.EntityFrameworkCore.PostgreSQL` (8.0.4)
- `Swashbuckle.AspNetCore` (6.6.2)

### Docker

The project is configured to target Linux for Docker deployment. Ensure you have Docker installed and running on your machine.

## Getting Started

1. **Clone the repository:**

    ```bash
    git clone https://github.com/your-repository/sample_jwt.git
    cd sample_jwt
    ```

2. **Set up User Secrets:**

    Configure your User Secrets for sensitive information such as database connection strings and JWT secret keys.

    ```bash
    dotnet user-secrets init
    dotnet user-secrets set "YourSecretKey" "YourSecretValue"
    ```

3. **Build and run the project:**

    ```bash
    dotnet build
    dotnet run
    ```

4. **Run with Docker:**

    Build and run the Docker container:

    ```bash
    docker build -t sample_jwt .
    docker run -p 8080:80 sample_jwt
    ```

## API Documentation

Swagger is used for API documentation. Once the project is running, you can access the API documentation at:

```
http://localhost:{port}/swagger
```

## License

This project is licensed under the MIT License - see the LICENSE.md file for details.

## Acknowledgements

Special thanks to the contributors of the various NuGet packages used in this project.

---