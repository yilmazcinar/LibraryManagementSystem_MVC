using LibraryManagementSystem_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LibraryManagementSystem_MVC.Controllers
{
    public class BookController : Controller
    {

        public static List<Book> books = new List<Book>()
        {

            new Book { Id = 1, Title = "Patasana", AuthorId = 2, Genre = "Fiction", PublishDate = new DateTime(2000, 4, 10), ISBN = "9780743273565", CopiesAvailable = 5, ImageUrl = "https://img.kitapyurdu.com/v1/getImage/fn:10083640/wh:true/miw:200/mih:200", BookSummary = "Bir Cinayet Polisiyesi", AuthorName="Ahmet Ümit" },

            new Book { Id = 2, Title = "The Lord of the Rings", AuthorId = 1, Genre = "Fantasy", PublishDate = new DateTime(1954, 7, 29), ISBN = "9780618640157", CopiesAvailable = 3, ImageUrl = "https://muddypearl.com/wp-content/uploads/2021/01/LOTR-Cover-Small.jpg", BookSummary="2 Cücenin yüzüğü Mordor dağına taşıdığı yolculuğun hikayesi.", AuthorName = "JR.Tolkien" },

            new Book { Id = 3, Title = "The Chess", AuthorId = 3, Genre = "Fiction", PublishDate = new DateTime(1942, 10, 15), ISBN = "9780140280577", CopiesAvailable = 2, ImageUrl = "https://m.media-amazon.com/images/I/61ialm+EQ2L._AC_UF1000,1000_QL80_.jpg", BookSummary = "2. Dünya savaşında hapise atılan danimarkalı bir noter'in hapiste satranç ile paranoyak tecrübesi.", AuthorName = "Stefan Zweig"}




            };
        private int id;

        public IActionResult List()
        {
            return View(books);
        }
        public IActionResult Details(int id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);
            if (book == null) return NotFound();
            return View(book);
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.authors = AuthorController.authors.Select(a => new SelectListItem
            {
                Value = a.Id.ToString(),
                Text = $"{a.FirstName} {a.LastName}"


            }).ToList();

            return View();
        }

        //[HttpPost]
        //public IActionResult Create(Book newBook)
        //{


        //    var author = AuthorController.authors.FirstOrDefault(a => a.Id == newBook.AuthorId);
        //    newBook.AuthorName = author.FirstName + " " + author.LastName;
        //    return View(newBook);


        //}

        [HttpPost]
        public IActionResult Create(Book newBook)
        {
            
            
                // 1. Yazar kontrolü
                var author = AuthorController.authors.FirstOrDefault(a => a.Id == newBook.AuthorId);

                if (author == null)
                {
                    
                    return View(newBook);
                }

                // 2. AuthorName'i ata
                newBook.AuthorName = $"{author.FirstName} {author.LastName}";

                // 3. Yeni ID ata ve listeye ekle
                newBook.Id = BookController.books.Count + 1;
                BookController.books.Add(newBook);

                // 4. Listeye yönlendir
                return RedirectToAction("List");
            

            
        }

        public IActionResult Edit(int id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);
            if (book == null) return NotFound();
            return View(book);
        }

        [HttpPost]
        public IActionResult Edit(int id, Book book)
        {
            

            
            
                var existingBook = books.FirstOrDefault(b => b.Id == id);
                if (existingBook == null) return NotFound();

                // Güncelleme işlemleri
                existingBook.Title = book.Title;
                existingBook.AuthorId = book.AuthorId;
                existingBook.AuthorName = book.AuthorName;
                existingBook.Genre = book.Genre;
                existingBook.PublishDate = book.PublishDate;
                existingBook.ISBN = book.ISBN;
                existingBook.CopiesAvailable = book.CopiesAvailable;
                existingBook.ImageUrl = book.ImageUrl;
                existingBook.BookSummary = book.BookSummary;

                return RedirectToAction("List");
            
            
        }


        public IActionResult Delete(int id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);
            books.Remove(book);
            return RedirectToAction("List");
        }
    }
}
