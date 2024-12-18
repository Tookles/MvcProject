using System.Diagnostics.Metrics;

namespace MvcProject.Models.Entity
{
    public class Author
    {
        public static int count = 18;

        public Author()
        {
            Id = count;
            count++;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Nationality { get; set; }
    }
}
