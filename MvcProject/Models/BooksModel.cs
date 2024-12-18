using MvcProject.Models.Entity;
using System.Text.Json;
namespace MvcProject.Models

{
    public class BooksModel
    {
        public List<Book>? FetchBooks()
        {
            var jsonBooks = File.ReadAllText("Resources\\Books.json");
            return JsonSerializer.Deserialize<List<Book>>(jsonBooks);
        }

        public Book? FetchBookById(int id)
        {
            var bookList = FetchBooks();
            return bookList.FindAll(b => b.Id == id).First();
        }

        public void AddBook(Book book)
        {
            var bookList = FetchBooks();
            bookList.Add(book);
            string json = JsonSerializer.Serialize(bookList, new JsonSerializerOptions() { WriteIndented = true });
            File.WriteAllText("Resources\\Books.json", json);
        }

        public void DeleteBookById(int id)
        {
            var bookList = FetchBooks();
            bookList.RemoveAll(b => b.Id == id);
            string json = JsonSerializer.Serialize(bookList, new JsonSerializerOptions() { WriteIndented = true });
            File.WriteAllText("Resources\\Books.json", json);
        }

        public List<Book>? FetchBookByAuthorId(int authorId)
        {
            var bookList = FetchBooks();
            var jsonAuthors = File.ReadAllText("Resources\\Authors.json");
            var authorsList = JsonSerializer.Deserialize<List<Author>>(jsonAuthors);

            return bookList
                .Where(b => b.Author == authorsList
                .Where(a => a.Id == authorId)
                .Select(a => a.Name)
                .First())
                .ToList();
        }
    }
}
