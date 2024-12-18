using MvcProject.Models;
using MvcProject.Models.Entity;

namespace MvcProject.Services
{
    public class AuthorsService
    {

        private readonly AuthorsModel _authorsModel; 

        public AuthorsService(AuthorsModel authorModel)
        {
            _authorsModel = authorModel;
        }

        public Author GetAuthorById(int id)
        {
            return _authorsModel.FetchAuthorById(id);
        }

        public List<Author> GetAllAuthors()
        {
            return _authorsModel.FetchAuthors(); 
        }

        public void AddAuthor(Author author)
        {
            _authorsModel.AddAuthor(author);   
        }

    }
}
