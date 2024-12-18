namespace MvcProject.Models.Entity
{
    public class Book
    {
        public static int count = 10;
        public int Id { get; set; }

        public Book()
        {
            Id = count;
            count++;
        }

        public string Title { get; set; }

        public string Author { get; set; }
        public int Year { get; set; }
    }
}
