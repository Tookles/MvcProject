using Microsoft.AspNetCore.Mvc;
using MvcProject.Services;
using MvcProject.Models.Entity;

namespace MvcProject.Controllers
{
    [ApiController]
    [Route("/[controller]")]
    public class AuthorsController : Controller
    {
        private readonly AuthorsService _authorsService;

        public AuthorsController(AuthorsService authorService)
        {
            _authorsService = authorService;
        }

        [HttpGet]
        public IActionResult GetAuthors()
        {
            var returnAuthors = _authorsService.GetAllAuthors(); 
            return Ok(returnAuthors);
        }

        [HttpGet("{id}")]
        public IActionResult GetAuthors(int id)
        {
            var returnAuthor = _authorsService.GetAuthorById(id);
            return Ok(returnAuthor);
        }

        [HttpPost]
        public IActionResult AddAuthor(Author author)
        {
            _authorsService.AddAuthor(author);
            return StatusCode(201);
        }
    }
}
