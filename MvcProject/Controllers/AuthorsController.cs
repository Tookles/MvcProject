using Microsoft.AspNetCore.Mvc;
using MvcProject.Services;

namespace MvcProject.Controllers
{

    [ApiController]
    [Route("/[controller]")]
    public class AuthorsController : Controller
    {

        private readonly AuthorsService _authorService;

        public AuthorsController(AuthorsService authorService)
        {
            _authorService = authorService;
        }


        [HttpGet]
        public IActionResult GetAuthors()
        {
            var returnAuthors = _authorService.GetAllAuthors(); 
            return Ok(returnAuthors);
        }
    }
}
