# Library Management System

## Project Description

This project is an **ASP.NET Core MVC** application developed to manage books and authors in a library. Users can add, edit, and delete books and authors in the system.

## Technologies

- **ASP.NET Core MVC**
- **Bootstrap** (For UI Design)
- **HTML, CSS, JavaScript**

## Project Requirements

### Model Creation

#### Book Model

- **Id**: int (Unique identifier)
- **Title**: string (Book title)
- **AuthorId**: int (Author ID, reference to **Author** model)
- **Genre**: string (Book genre)
- **PublishDate**: DateTime (Publication date)
- **ISBN**: string (ISBN number)
- **CopiesAvailable**: int (Available copies)

#### Author Model

- **Id**: int (Unique identifier)
- **FirstName**: string (Author's first name)
- **LastName**: string (Author's last name)
- **DateOfBirth**: DateTime (Date of birth)

### ViewModel Creation

- ViewModel to display book details and lists
- ViewModel to display author details and lists

### Controller Creation

#### **BookController**

- **List**: Displays the list of books.
- **Details**: Shows details of a selected book.
- **Create**: Provides a form to add a new book.
- **Edit**: Provides a form to edit an existing book.
- **Delete**: Provides a confirmation page to delete a book.

#### **AuthorController**

- **List**: Displays the list of authors.
- **Details**: Shows details of a selected author.
- **Create**: Provides a form to add a new author.
- **Edit**: Provides a form to edit an existing author.

### View Creation

#### **Book Views**

- **List.cshtml**: Displays the book list.
- **Details.cshtml**: Displays the details of a selected book.
- **Create.cshtml**: Form to add a new book.
- **Edit.cshtml**: Form to edit a book.

#### **Author Views**

- **List.cshtml**: Displays the author list.
- **Details.cshtml**: Displays author details.
- **Create.cshtml**: Form to add a new author.
- **Edit.cshtml**: Form to edit an author.

### **Program.cs Configuration**

- Add MVC services.
- Enable **wwwroot** folder usage.
- Configure routing.
- Set default **HomeController** and **Index** action.

## **Extras**

- Use **Layout & PartialView**.
- A fixed **footer** at the bottom of the page.
- **Home Page** and **About Page**.



## **License**

This project is licensed under the **MIT** license.




