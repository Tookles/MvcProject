using MvcProject.Models; 

namespace MvcProject.Services
{
    public class AuthorsService
    {

        private readonly AuthorsModel _authorModel; 

        public AuthorsService(AuthorsModel authorModel)
        {
            _authorModel = authorModel;
        }



        public List<Author> GetAllAuthors()
        {
            return _authorModel.FetchAuthors(); 
        }

    }
}
