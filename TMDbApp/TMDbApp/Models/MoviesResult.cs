using System.Collections.Generic;

namespace TMDbApp.Models
{
    public class MoviesResult
    {
        public List<Movie> Results { get; set; }
        public int Total_Pages { get; set; }
        public int Total_Results { get; set; }
    }
}
