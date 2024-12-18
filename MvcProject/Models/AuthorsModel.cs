using System.Text.Json;
using MvcProject.Models.Entity;

namespace MvcProject.Models
{
    public class AuthorsModel
    {
        public List<Author>? FetchAuthors()
        {
            var jsonAuthors = File.ReadAllText("resources/Authors.json");
            List<Author>? authorList = JsonSerializer.Deserialize<List<Author>>(jsonAuthors); 
            return authorList; 
        }

        public Author? FetchAuthorById(int id)
        {
            var jsonAuthors = File.ReadAllText("resources/Authors.json");
            List<Author>? authorList = JsonSerializer.Deserialize<List<Author>>(jsonAuthors);
            return authorList.FindAll(a => a.Id == id).First();
        }

        public void AddAuthor(Author author)
        {
            var jsonAuthors = File.ReadAllText("resources/Authors.json");
            List<Author>? authorList = JsonSerializer.Deserialize<List<Author>>(jsonAuthors);
            author.Id = authorList.Count + 1;
            authorList.Add(author);
            string json = JsonSerializer.Serialize<List<Author>>(authorList, new JsonSerializerOptions() { WriteIndented = true });
            File.WriteAllText("Resources\\Authors.json", json);
        }
    }
}
