using Microsoft.AspNetCore.Mvc;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Controllers
{
    public class BookController : Controller
    {
        public static List<Book> _books = new List<Book>
        {
            new Book { Id = 1, Title = "1984", Genre = "Dystopian", PublishDate = new DateTime(1949, 6, 8), ISBN = "123456789", CopiesAvailable = 5 },
            new Book { Id = 2, Title = "Animal Farm", Genre = "Allegory", PublishDate = new DateTime(1945, 8, 17), ISBN = "234567890", CopiesAvailable = 3 },
            new Book { Id = 3, Title = "Crime and Punishment", Genre = "Philosophical Novel", PublishDate = new DateTime(1866, 1, 1), ISBN = "345678901", CopiesAvailable = 4 },
            new Book { Id = 4, Title = "The Brothers Karamazov", Genre = "Philosophical Novel", PublishDate = new DateTime(1880, 11, 1), ISBN = "456789012", CopiesAvailable = 2 },
            new Book { Id = 5, Title = "Brave New World", Genre = "Dystopian", PublishDate = new DateTime(1932, 8, 31), ISBN = "567890123", CopiesAvailable = 6 },
            new Book { Id = 6, Title = "Fahrenheit 451", Genre = "Dystopian", PublishDate = new DateTime(1953, 10, 19), ISBN = "678901234", CopiesAvailable = 7 },
            new Book { Id = 7, Title = "The Great Gatsby", Genre = "Tragedy", PublishDate = new DateTime(1925, 4, 10), ISBN = "789012345", CopiesAvailable = 8 },
            new Book { Id = 8, Title = "To Kill a Mockingbird", Genre = "Southern Gothic", PublishDate = new DateTime(1960, 7, 11), ISBN = "890123456", CopiesAvailable = 5 }
        };

        // Kitaplar listelenecek
        public IActionResult List()
        {
            return View(_books);
        }

        // Kitap detayları
        public IActionResult Details(int id)
        {
            var book = _books.FirstOrDefault(b => b.Id == id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }

        // Yeni kitap eklemek için form
        public IActionResult Create()
        {
            // Sabit bir authors listesi oluşturuyoruz
            var authors = new List<Author>
            {
                new Author { Id = 1, FirstName = "George", LastName = "Orwell" },
                new Author { Id = 2, FirstName = "Fyodor", LastName = "Dostoyevski" },
                new Author { Id = 3, FirstName = "Aldous", LastName = "Huxley" }
            };

            ViewBag.Authors = authors; // Sabit listeyi ViewBag'e ekliyoruz
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                book.Id = _books.Count > 0 ? _books.Max(b => b.Id) + 1 : 1; // Yeni ID oluştur
                _books.Add(book); // Kitabı listeye ekle

                return RedirectToAction(nameof(List)); // Listeye yönlendir
            }

            return View(book); // Hatalıysa formu tekrar göster
        }


        // Kitap düzenleme formu
        public IActionResult Edit(int id)
        {
            var book = _books.FirstOrDefault(b => b.Id == id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Book book)
        {
            if (id != book.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var existingBook = _books.FirstOrDefault(b => b.Id == id);
                if (existingBook == null)
                {
                    return NotFound();
                }

                // Güncelleme işlemi
                existingBook.Title = book.Title;
                existingBook.Genre = book.Genre;
                existingBook.PublishDate = book.PublishDate;
                existingBook.ISBN = book.ISBN;
                existingBook.CopiesAvailable = book.CopiesAvailable;

                return RedirectToAction(nameof(List));
            }

            return View(book);
        }


        // Kitap silme işlemi
        public IActionResult Delete(int id)
        {
            var book = _books.FirstOrDefault(B => B.Id == id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var book = _books.FirstOrDefault(b => b.Id == id);
            if (book == null)
            {
                return NotFound();
            }

            _books.Remove(book);
            return RedirectToAction(nameof(List));
        }

    }
}
