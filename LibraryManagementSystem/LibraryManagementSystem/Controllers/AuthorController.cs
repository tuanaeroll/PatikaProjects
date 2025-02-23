using Microsoft.AspNetCore.Mvc;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Controllers
{
    public class AuthorController : Controller
    {
        public static List<Author> _authors = new List<Author>
        {
            new Author { Id = 1, FirstName = "George", LastName = "Orwell" },
            new Author { Id = 2, FirstName = "Fyodor", LastName = "Dostoyevski" },
            new Author { Id = 3, FirstName = "Aldous", LastName = "Huxley" },
            new Author { Id = 4, FirstName = "Ray", LastName = "Bradbury" },
            new Author { Id = 5, FirstName = "F. Scott", LastName = "Fitzgerald" },
            new Author { Id = 6, FirstName = "Harper", LastName = "Lee" }
        };

        public IActionResult List()
        {
            return View(_authors);
        }

        public IActionResult Details(int id)
        {
            var author = _authors.FirstOrDefault(a => a.Id == id);
            if (author == null)
            {
                return NotFound();
            }

            return View(author);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Author author)
        {
            if (ModelState.IsValid)
            {
                author.Id = _authors.Any() ? _authors.Max(a => a.Id) + 1 : 1;
                _authors.Add(author);

                return RedirectToAction(nameof(List));
            }

            return View(author);
        }

        public IActionResult Edit(int id)
        {
            var author = _authors.FirstOrDefault(a => a.Id == id);
            if (author == null)
            {
                return NotFound();
            }

            return View(author);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Author author)
        {
            if (id != author.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var existingAuthor = _authors.FirstOrDefault(a => a.Id == id);
                if (existingAuthor == null)
                {
                    return NotFound();
                }

                existingAuthor.FirstName = author.FirstName;
                existingAuthor.LastName = author.LastName;

                return RedirectToAction(nameof(List));
            }

            return View(author);
        }

        public IActionResult Delete(int id)
        {
            var author = _authors.FirstOrDefault(a => a.Id == id);
            if (author == null)
            {
                return NotFound();
            }

            return View(author);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var author = _authors.FirstOrDefault(a => a.Id == id);
            if (author == null)
            {
                return NotFound();
            }

            _authors.Remove(author);
            return RedirectToAction(nameof(List));
        }
    }
}
   