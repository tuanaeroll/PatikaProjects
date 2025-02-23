﻿namespace LibraryManagementSystem.Models
{
    public class AuthorViewModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public List<string>? BookTitles { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
