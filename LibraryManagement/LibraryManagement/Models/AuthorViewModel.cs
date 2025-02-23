namespace LibraryManagement.Models
{
    public class AuthorViewModel
    {
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<string> Books { get; set; }
    }
}
