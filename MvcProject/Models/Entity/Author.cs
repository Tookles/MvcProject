﻿using System.Diagnostics.Metrics;

namespace MvcProject.Models.Entity
{
    public class Author
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Nationality { get; set; }

        public List<Book> Books { get; set; }
    }
}
