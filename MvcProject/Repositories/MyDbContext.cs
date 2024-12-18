using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using MvcProject.Models.Entity;

namespace MvcProject.Repositories
{
    public class MyDbContext : DbContext
    {

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(JsonSerializer.Deserialize<List<Author>>(File.ReadAllText("Resources/Authors.json")));
            modelBuilder.Entity<Book>().HasData(JsonSerializer.Deserialize<List<Book>>(File.ReadAllText("Resources/Books.json")));

        }

    }
}
