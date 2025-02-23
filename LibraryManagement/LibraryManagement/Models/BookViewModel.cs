namespace LibraryManagement.Models
{
    public class BookViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string ISBN { get; set; }
        public DateTime PublishDate { get; set; }
        public int CopiesAvailable { get; set; }
        public string AuthorName { get; set; }
    }
}
