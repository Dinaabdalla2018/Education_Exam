# Online Education Project

This is a web application for online education that allows students to take exams and check their grades. The application provides three types of users, Admin, Student, and Public user. The application is built using Angular as the frontend and ASP.NET Core Web API as the backend. The authentication process is implemented using JWT (JSON Web Token) authentication. The application generates a token to check the authenticated user.

## Prerequisites 
- Angular CLI
- Visual Studio 2020
- .NET Core 7
- SQL Server 2019 or later

## Getting Started

1. Clone the repository to your local machine.
2. Open the solution file `QuizeApp.sln` in Visual Studio.
3. Open the `appsettings.json` file in the `QuizeApp.API` project and replace the database connection string with your own.
4. Open the Package Manager Console in Visual Studio and run the following command to create the database tables:

```
Update-Database
```

5. Build and run the solution in Visual Studio. This will launch the API on `https://localhost:5001` and the Angular application on `http://localhost:4200`.

## Features

### Admin

The admin can perform the following actions:

- Login to the application.
- Add, edit, and delete exams.
- Edit and update questions in each exam.

### Student

The student can perform the following actions:

- Register and login to the application.
- Take exams.
- Check their grades.

### Public User

The public user can perform the following actions:

- Register and login to the application.
- View the home, about, and contact pages.

## Authentication

The application uses password hashing and salting in the database to store user passwords securely. When a user logs in, the application generates a token that is used to check if the user is authenticated or not.

## Built With

- Angular - A front-end web application framework.
- ASP.NET Core Web API - A back-end web application framework.
- SQL Server - A relational database management system.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
