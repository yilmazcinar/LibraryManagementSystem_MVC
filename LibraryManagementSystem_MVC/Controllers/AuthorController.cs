using LibraryManagementSystem_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using static System.Reflection.Metadata.BlobBuilder;

namespace LibraryManagementSystem_MVC.Controllers
{
    public class AuthorController : Controller
    {

        public static List<Author> authors = new List<Author>()
        {

            new Author()
            {
                Id = 1,
                FirstName = "JR",
                LastName = "Tolkien",
                DateOfBirth = new DateTime(1892, 3, 1),
                ImageUrl = "https://cdn.britannica.com/65/66765-050-63A945A7/JRR-Tolkien.jpg ",
                About ="John Ronald Reuel Tolkien, İngiliz yazar, şair, filolog ve akademisyen. Hobbit ve Yüzüklerin Efendisi gibi fantastik kurgu eserleriyle tanınır. 1925'ten 1945'e kadar Tolkien, Oxford Üniversitesi'nde Rawlinson ve Bosworth Anglo-Sakson Profesörü ve Pembroke Koleji Üyesiydi."
            },

            new Author()
            {
                Id = 2,
                FirstName = "Ahmet",
                LastName = "Ümit",
                DateOfBirth = new DateTime(1960, 09, 30),
                ImageUrl = "https://www.alfayayinlari.com/upload/ahmet_umit.jpg",
                About ="Ahmet Ümit, Türk şair ve yazardır. Daha çok polisiye roman türünde eser veren bir yazardır."
            },

            new Author()
            {
                Id = 3,
                FirstName = "Stefan",
                LastName = "Zweig",
                DateOfBirth = new DateTime(1881, 11, 28),
                ImageUrl = "https://www.ithakiyayingrubu.com/dosyalar/2022/02/Stefan-Zweig.jpg",
                About ="Stefan Zweig, Avusturyalı yazar ve gazeteciydi. Edebi kariyerinin zirvesinde olduğu 1920'li ve 1930'lu yıllarda, dünyanın en çok çevrilen ve en popüler yazarlarından biriydi. Zweig, Viyana, Avusturya-Macaristan'da büyüdü."
            }


        };
        public IActionResult List()
        {
            return View(authors);
        }
        public IActionResult Details(int id)
        {
            var author = authors.FirstOrDefault(a => a.Id == id);
            if (authors == null) return NotFound();
            return View(author);
            
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
       
        [HttpPost]
        
        public IActionResult Create(Author author)
        {
            
           
                // ID'yi manuel olarak artır
                author.Id = authors.Count + 1;
                authors.Add(author);
                return RedirectToAction("List");
            
            
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var author = authors.FirstOrDefault(a => a.Id == id);
            if (author == null) return NotFound();
            return View(author);
        }


            [HttpPost]
        public IActionResult Edit(int id, Author author)
        {
            

            
            
                var existingAuthor = authors.FirstOrDefault(a => a.Id == id);
                if (existingAuthor == null) return NotFound();

                // Güncelleme işlemleri
                existingAuthor.FirstName = author.FirstName;
                existingAuthor.LastName = author.LastName;
                existingAuthor.DateOfBirth = author.DateOfBirth;
                existingAuthor.ImageUrl = author.ImageUrl;
                existingAuthor.About = author.About;

                return RedirectToAction("List");
            
            
        }

        public IActionResult Delete(int id)
        {
            var author = authors.FirstOrDefault(a => a.Id == id);

            authors.Remove(author);
            return RedirectToAction("List");
        }
    }
}
