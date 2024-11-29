# DotNet9WithMemDB

This is a minimal API project built with .NET 9 and an in-memory database.

## Overview

This project demonstrates the following concepts:

- **Minimal APIs**: A streamlined approach to building APIs with minimal setup and configuration.
- **In-Memory Database**: Using an in-memory database for quick development and testing without the need for a full-fledged database server.
- **Dependency Injection**: Leveraging .NET's built-in dependency injection to manage service lifetimes and dependencies.
- **Entity Framework Core**: An ORM (Object-Relational Mapper) for interacting with the in-memory database using LINQ queries.
- **Asynchronous Programming**: Utilizing async/await for non-blocking I/O operations to improve performance and scalability.
- **Unit Testing**: Writing unit tests to ensure the correctness of the application logic.

These concepts are combined to create a robust and maintainable API that can be easily extended and tested.

## Getting Started

### Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)

### Installation

1. Clone the repository:
   ```sh
   git clone https://github.com/yourusername/DotNet9WithMemDB.git
   ```
2. Navigate to the project directory:
   ```sh
   cd DotNet9WithMemDB
   ```
3. Restore the dependencies:
   ```sh
   dotnet restore
   ```

### Running the Application

To run the application, use the following command:

```sh
dotnet run
```

The API will be available at `https://localhost:5001`.

### Testing

To run the tests, use the following command:

```sh
dotnet test
```

## Project Structure

- `Program.cs`: Entry point of the application.
- `Startup.cs`: Configures services and the app's request pipeline.
- `Controllers/`: Contains API controllers.
- `Models/`: Contains data models.
- `Data/`: Contains the in-memory database context.

## Contributing

Contributions are welcome! Please fork the repository and create a pull request.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## Acknowledgements

- [Microsoft](https://dotnet.microsoft.com/) for .NET
- [GitHub Copilot](https://github.com/features/copilot) for assistance in code generation

## Follow My Blog

For more tutorials and insights on .NET and other technologies, visit my blog at [sma.im](https://sma.im). Don't forget to subscribe and stay updated with the latest posts!

Happy coding!
