namespace LibraryManagementSystem_MVC.Models;

public class BookListViewModel
{
    public string Title { get; set; }

    public string Genre { get; set; }

    public DateTime PublishDate { get; set; }

    public int CopiesAvailable { get; set; }

    public string AuthorName { get; set; }

    public string ImageUrl { get; set; }

    public string BookSummary { get; set; }

}
