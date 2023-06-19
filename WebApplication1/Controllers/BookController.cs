using BookStoreApplicationOriginal.Models;
using BookStoreApplicationOriginal.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreApplicationOriginal.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;
        public BookController()
        {
            _bookRepository = new BookRepository();
        }
        public IActionResult AllBooks()
        {
            var data =_bookRepository.GetAllBooks();
            return View(data);
        }
        public IActionResult GetBooks(int id)
        {
            var data =  _bookRepository.GetBookById(id);
            return View(data);
        }

        public List<BooksModel> SearchBooks(string bookName, string authorName) 
        {
            return _bookRepository.SearchBooks(bookName, authorName);
        }

    }
}
