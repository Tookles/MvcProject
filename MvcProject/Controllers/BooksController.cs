using Microsoft.AspNetCore.Mvc;
using MvcProject.Services;
using MvcProject.Models.Entity;

namespace MvcProject.Controllers
{
    [ApiController]
    [Route("/[controller]")]
    public class BooksController : Controller
    {
        private readonly BooksService _booksService;

        public BooksController(BooksService booksServices)
        {
            _booksService = booksServices;
        }

        [HttpGet]
        public IActionResult GetAllBooks()
        {
            var returnBooks = _booksService.GetAllBooks();
            return Ok(returnBooks);
        }

        [HttpGet("{id}")]
        public IActionResult GetBookById(int id)
        {
            var returnBook = _booksService.GetBookById(id);
            return Ok(returnBook);
        }

        [HttpPost]
        public IActionResult AddBook(Book book)
        {
            _booksService.AddBook(book);
            return StatusCode(201, book);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBookById(int id)
        {
            _booksService.DeleteBookById(id);
            return StatusCode(204);
        }

        [HttpGet("/books/author/{authorId}")]
        public IActionResult GetBooksByAuthorId(int authorId)
        {
            var returnBooks = _booksService.GetBookById(authorId);
            return Ok(returnBooks);
        }
    }
}
