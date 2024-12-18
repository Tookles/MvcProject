using MvcProject.Models;
using MvcProject.Models.Entity;

namespace MvcProject.Services
{
    public class BooksService
    {
        private readonly BooksModel? _booksModel;

        public BooksService(BooksModel booksModel)
        {
            _booksModel = booksModel;
        }

        public List<Book>? GetAllBooks()
        {
            return _booksModel.FetchBooks();
        }

        public Book? GetBookById(int id)
        {
            return _booksModel.FetchBookById(id);
        }

        public void AddBook(Book book)
        {
            _booksModel.AddBook(book);
        }

        public void DeleteBookById(int id)
        {
            _booksModel.DeleteBookById(id);
        }

        public void GetBooksByAuthorId(int authorId)
        {
            _booksModel.FetchBookByAuthorId(authorId);
        }
    }
}
