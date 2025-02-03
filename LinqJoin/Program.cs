using LinqJoin;

var authors = new List<Author>
    {
        new Author { AuthorId = 1, Name = "J.K. Rowling" },
        new Author { AuthorId = 2, Name = "George Orwell" },
        new Author { AuthorId = 3, Name = "J.R.R. Tolkien" }
    };

var books = new List<Book>
    {
        new Book { BookId = 1, Title = "Harry Potter and the Sorcerer's Stone", AuthorId = 1 },
        new Book { BookId = 2, Title = "1984", AuthorId = 2 },
        new Book { BookId = 3, Title = "Animal Farm", AuthorId = 2 },
        new Book { BookId = 4, Title = "The Hobbit", AuthorId = 3 }
    };

var query = from book in books
            join author in authors on book.AuthorId equals author.AuthorId
            select new
            {
                BookTitle = book.Title,
                AuthorName = author.Name
            };

foreach (var item in query)
{
    Console.WriteLine($"📖 {item.BookTitle} - ✍ {item.AuthorName}");
}