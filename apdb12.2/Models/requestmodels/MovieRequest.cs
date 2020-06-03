using System;

namespace apdb12._2.Models.requestmodels
{
    public class MovieRequest
    {
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public double Price { get; set; }
    }
}