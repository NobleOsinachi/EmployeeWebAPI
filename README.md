
# Employee Web API Demo

Used to fetch the database of employees to be used in another front-end employee management & payroll system. This project helped me understand the basics of creating a Web API and testing it using Postman.

Bootstrapped with the default MVC project template, it only has one `Employee` model class, with an `EmployeeController` for performing the CRUD (Create Read Update Delete) operations.

## Installation

To run the Employee-Web API Demo locally, follow these steps:

1. Clone the repository to your local machine using the following command:

```bash
git clone https://github.com/your-username/Employee-Web-API-Demo.git
```

2. Change into the project directory:

```bash
cd Employee-Web-API-Demo
```

3. Install the required dependencies:

```bash
dotnet restore
```

4. Start the development server:

```bash
dotnet run
```

5. The API will be accessible at `http://localhost:5000` by default.

## Usage

The Employee-Web API provides the following endpoints:

- `GET /api/employees`: Get a list of all employees.
- `GET /api/employees/{id}`: Get a specific employee by ID.
- `POST /api/employees`: Add a new employee to the database.
- `PUT /api/employees/{id}`: Update an existing employee's information.
- `DELETE /api/employees/{id}`: Delete an employee from the database.

You can use tools like Postman to test these endpoints and interact with the API.

## Contributing

Contributions are welcome! If you'd like to contribute to the project, please follow these steps:

1. Fork the repository on GitHub.
2. Clone your forked repository to your local machine.
3. Create a new branch with a descriptive name for your feature or bug fix.
4. Make your changes and commit them with descriptive commit messages.
5. Push your changes to your forked repository on GitHub.
6. Submit a pull request to the main repository.

Please ensure that your code adheres to the project's coding standards and practices.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
