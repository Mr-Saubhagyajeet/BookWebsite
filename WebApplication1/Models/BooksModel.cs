﻿namespace BookStoreApplicationOriginal.Models
{
    public class BooksModel
    {
        public int Id { get; set; }
        public string ImagePath { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public float Amount{ get; set; }
    }
}
