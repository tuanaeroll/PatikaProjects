# Library Management System

## Project Overview

This is a **Library Management System** built using **ASP.NET Core MVC** and **.NET 9**. The system allows managing books and authors in a library. It provides features such as adding, updating, deleting, and viewing books and authors. 

In this project, I used **in-memory data** instead of a database to keep things simple and fast. Additionally, I implemented functionality for both `Book` and `Author` models, enabling users to perform similar operations on both.

---

## Features

- **Book Management**: 
  - Add a book
  - Update a book
  - Delete a book
  - View a list of books

- **Author Management**:
  - Add an author
  - Update an author
  - Delete an author
  - View a list of authors

---

## Technologies Used

- **ASP.NET Core MVC**: Used for building the web application following the Model-View-Controller design pattern.
- **.NET 9**: The framework and runtime for building and running the application.
- **In-memory data storage**: Instead of using a traditional database, I used hardcoded lists to simulate the book and author data.

---

## Project Structure

- **Models**:
- `Book`: Represents a book in the library. Contains properties like `Title`, `Author`, `Genre`, and `ISBN`.
- `Author`: Represents an author in the library. Contains properties like `Name`.

- **Controllers**:
- `BooksController`: Handles the logic related to books, including adding, updating, deleting, listing, and searching for books.
- `AuthorsController`: Similar to `BooksController`, this controller handles operations related to authors.

- **Views**:
- Razor Views are used for displaying HTML content. Each action in the controllers is linked to a corresponding Razor view (e.g., `Create`, `Edit`, `Details`, and `Index` views for books and authors).

---

## How the System Works

### 1. **Model**
The two key models in the system are `Book` and `Author`.

- **Book Model**:
- `Title`: The title of the book.
- `Author`: The name of the book's author.
- `Genre`: The category or genre of the book (e.g., fiction, non-fiction).
- `ISBN`: The International Standard Book Number (used for identifying books).

- **Author Model**:
- `Name`: The name of the author.

These models are stored in in-memory lists that simulate data storage. Each list represents a collection of books or authors.

### 2. **Controllers**
I created two controllers: `BooksController` and `AuthorsController`. Both controllers have actions that perform CRUD operations:

- **BooksController**:
- `Index()`: Displays a list of all books.
- `Create()`: Displays a form to add a new book.
- `Edit()`: Displays a form to edit an existing book.
- `Delete()`: Deletes a selected book.
- `Details()`: Displays details of a specific book.

- **AuthorsController**:
- `Index()`: Displays a list of all authors.
- `Create()`: Displays a form to add a new author.
- `Edit()`: Displays a form to edit an existing author.
- `Delete()`: Deletes a selected author.
- `Details()`: Displays details of a specific author.

### 3. **In-Memory Data**
Instead of using a database, the system uses in-memory lists to store book and author data. These lists simulate a database, and the data persists only during the runtime of the application. This approach allows for a simple and fast prototype without needing to configure a database.

### 4. **Search Functionality**
Both the `BooksController` and `AuthorsController` support searching for books and authors by title or name. The user can input a keyword, and the system will filter the list to display matching results.

---

## Conclusion

This Library Management System demonstrates how to manage books and authors in a library using the **ASP.NET Core MVC** framework. The application follows the MVC pattern, ensuring clear separation of concerns, and provides a user-friendly interface for managing books and authors.

Feel free to clone the project and modify it according to your needs!

---

## License

This project is licensed under the MIT License.
