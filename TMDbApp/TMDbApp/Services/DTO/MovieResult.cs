using System.Collections.Generic;

namespace TMDbApp.Services.DTO
{
    public class MoviesResult
    {
        public List<Movie> results { get; set; }
        public int total_pages { get; set; }
        public int total_results { get; set; }
    }
}
