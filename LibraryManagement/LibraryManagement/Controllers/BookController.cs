using Microsoft.AspNetCore.Mvc;
using LibraryManagement.Models;


namespace LibraryManagement.Controllers
{
    public class BookController : Controller
    {
        private static List<BookViewModel> books = new List<BookViewModel>
        {
            new BookViewModel { Title = "1984", Genre = "Dystopian", ISBN = "978-0451524935", PublishDate = new DateTime(1949, 6, 8), CopiesAvailable = 5, AuthorName = "George Orwell" },
            new BookViewModel { Title = "To Kill a Mockingbird", Genre = "Fiction", ISBN = "978-0061120084", PublishDate = new DateTime(1960, 7, 11), CopiesAvailable = 3, AuthorName = "Harper Lee" },
            new BookViewModel { Title = "Brave New World", Genre = "Science Fiction", ISBN = "978-0060850524", PublishDate = new DateTime(1932, 8, 31), CopiesAvailable = 2, AuthorName = "Aldous Huxley" }
        };

        // Kitapları listeleme
        public IActionResult List()
        {
            return View(books);
        }

        // Kitap detaylarını gösterme
        public IActionResult Details(string title)
        {
            var book = books.FirstOrDefault(b => b.Title == title);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }

        // Yeni kitap ekleme formunu gösterme
        public IActionResult Create()
        {
            return View();
        }

        // Yeni kitap ekleme işlemi
        [HttpPost]
        public IActionResult Create(BookViewModel model)
        {
            if (ModelState.IsValid)
            {
                books.Add(model);
                return RedirectToAction("List");
            }
            return View(model);
        }

        // Kitap düzenleme formunu gösterme
        public IActionResult Edit(string title)
        {
            var book = books.FirstOrDefault(b => b.Title == title);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }

        // Kitap düzenleme işlemi
        [HttpPost]
        public IActionResult Edit(string oldTitle, BookViewModel model)
        {
            var book = books.FirstOrDefault(b => b.Title == oldTitle);
            if (book == null)
            {
                return NotFound();
            }

            book.Title = model.Title;
            book.Genre = model.Genre;
            book.ISBN = model.ISBN;
            book.PublishDate = model.PublishDate;
            book.CopiesAvailable = model.CopiesAvailable;
            book.AuthorName = model.AuthorName;

            return RedirectToAction("List");
        }

        // Silme onay sayfasını gösterme
        public IActionResult Delete(string title)
        {
            var book = books.FirstOrDefault(b => b.Title == title);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }

        // Kitabı silme işlemi
        [HttpPost]
        public IActionResult DeleteConfirmed(string title)
        {
            var book = books.FirstOrDefault(b => b.Title == title);
            if (book != null)
            {
                books.Remove(book);
            }
            return RedirectToAction("List");
        }
    }
}
