using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TMDbApp.Models;
using TMDbApp.Services;
using TMDbApp.Helpers.Extensions;

namespace UnitTestProject1
{
    class MovieServiceMock : IMovieService
    {
        private IEnumerable<TMDbApp.Services.DTO.Genre> _genres;

        public MovieServiceMock()
        {
            Task.Run(GetGenresAsync);
        }

        public Task GetGenresAsync()
        {
            var result = MockValues.GetGenres();
            _genres = result.genres;
            return Task.FromResult(0);
        }

        public Task<MoviesResult> GetUpcomingMoviesAsync(int page)
        {
            var resultMovies = MockValues.GetUpcomingMovies();
            var movies = new List<Movie>();
            foreach (var movie in resultMovies.results)
                movies.Add(movie.ToModel(_genres));

            var result = new MoviesResult
            {
                Total_Pages = resultMovies.total_pages,
                Total_Results = resultMovies.total_results,
                Results = movies
            };
            return Task.FromResult(result);
        }

        public Task<MoviesResult> SearchAsync(string searchText, int page)
        {
            var moviesResult = MockValues.GetSearchMovies();
            var searchedList = moviesResult.results.Where(x => x.MovieName.Contains(searchText)).ToList();

            var movies = new List<Movie>();
            foreach (var movie in searchedList)
                movies.Add(movie.ToModel(_genres));

            var result = new MoviesResult
            {
                Total_Pages = moviesResult.total_pages,
                Total_Results = searchedList.Count,
                Results = movies
            };
            return Task.FromResult(result);
        }
    }
}
