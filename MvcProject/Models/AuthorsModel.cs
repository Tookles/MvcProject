using System.Text.Json; 

namespace MvcProject.Models
{
    public class AuthorsModel
    {
        public List<Author> FetchAuthors()
        {
            var jsonAuthors = File.ReadAllText("resources/Authors.json");
            List<Author> authorList = JsonSerializer.Deserialize<List<Author>>(jsonAuthors); 
            return authorList; 
        }
    }
}
