using System;

namespace apdb12._2.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }

        
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public double Price { get; set; }
    }
}