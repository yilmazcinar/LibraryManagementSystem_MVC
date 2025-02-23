namespace LibraryManagementSystem_MVC.Models;

public class Author
{


    public int Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string FullName => $"{FirstName} {LastName}";
    public DateTime DateOfBirth { get; set; }

    public string? ImageUrl { get; set; }

    public  string? About { get; set; }

}
