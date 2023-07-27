# WebAPIDemo API Documentation

The `WebAPIDemo` project provides an API for managing employee data. The API supports CRUD (Create, Read, Update, Delete) operations for the `Employee` resource.

## Base URL

The base URL for accessing the API is `https://your-api-base-url.com/api/employees/`.

## Employee Object

Each employee is represented by the following object:

```json
{
  "Id": "e7234f12-60ac-45b5-8df1-9769a3ab46d1",
  "FirstName": "John",
  "LastName": "Doe",
  "Gender": "Male",
  "Salary": 50000.00
}
```

- `Id` (string, unique, generated): The unique identifier for the employee (GUID).
- `FirstName` (string): The first name of the employee.
- `LastName` (string): The last name of the employee.
- `Gender` (string): The gender of the employee.
- `Salary` (decimal): The salary of the employee.

## Endpoints

### GET /api/employees

Get all employees.

#### Response

Status Code: 200 (OK)

```json
[
  {
    "Id": "e7234f12-60ac-45b5-8df1-9769a3ab46d1",
    "FirstName": "John",
    "LastName": "Doe",
    "Gender": "Male",
    "Salary": 50000.00
  },
  {
    "Id": "a58f9b35-68dc-42b5-a5c2-327e8a19e9b3",
    "FirstName": "Jane",
    "LastName": "Smith",
    "Gender": "Female",
    "Salary": 60000.00
  },
  ...
]
```

### GET /api/employees/{id}

Get an employee by ID.

#### Parameters

- `id` (string, required): The unique identifier (GUID) of the employee.

#### Response

Status Code: 200 (OK)

```json
{
  "Id": "e7234f12-60ac-45b5-8df1-9769a3ab46d1",
  "FirstName": "John",
  "LastName": "Doe",
  "Gender": "Male",
  "Salary": 50000.00
}
```

Status Code: 404 (Not Found) - If the employee with the given ID is not found.

### POST /api/employees

Create a new employee.

#### Request Body

The request body should be a JSON object representing the new employee to be added.

```json
{
  "FirstName": "John",
  "LastName": "Doe",
  "Gender": "Male",
  "Salary": 50000.00
}
```

#### Response

Status Code: 201 (Created)

```json
{
  "Id": "e7234f12-60ac-45b5-8df1-9769a3ab46d1",
  "FirstName": "John",
  "LastName": "Doe",
  "Gender": "Male",
  "Salary": 50000.00
}
```

Status Code: 400 (Bad Request) - If the request body is missing any required fields or contains invalid data.

### PUT /api/employees/{id}

Update an existing employee.

#### Parameters

- `id` (string, required): The unique identifier (GUID) of the employee to be updated.

#### Request Body

The request body should be a JSON object representing the updated employee data.

```json
{
  "FirstName": "John",
  "LastName": "Doe",
  "Gender": "Male",
  "Salary": 55000.00
}
```

#### Response

Status Code: 200 (OK)

```json
{
  "Id": "e7234f12-60ac-45b5-8df1-9769a3ab46d1",
  "FirstName": "John",
  "LastName": "Doe",
  "Gender": "Male",
  "Salary": 55000.00
}
```

Status Code: 400 (Bad Request) - If the request body contains invalid data.

Status Code: 404 (Not Found) - If the employee with the given ID is not found.

### DELETE /api/employees/{id}

Delete an employee by ID.

#### Parameters

- `id` (string, required): The unique identifier (GUID) of the employee to be deleted.

#### Response

Status Code: 200 (OK)

```json
{
  "Id": "e7234f12-60ac-45b5-8df1-9769a3ab46d1",
  "FirstName": "John",
  "LastName": "Doe",
  "Gender": "Male",
  "Salary": 50000.00
}
```

Status Code: 404 (Not Found) - If the employee with the given ID is not found.

## Error Handling

The API returns appropriate HTTP status codes and error messages in case of errors or invalid requests.

- Status Code: 400 (Bad Request) - Returned if the request is malformed or contains invalid data.
- Status Code: 404 (Not Found) - Returned if the requested resource (employee) is not found.
- Status Code: 500 (Internal Server Error) - Returned if there was an issue with the server while processing the request.
