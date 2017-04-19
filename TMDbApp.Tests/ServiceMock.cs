using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TMDbApp.Models;
using TMDbApp.Services;

namespace UnitTestProject1
{
    class ServiceMock : IMovieService<Movie>
    {
        public Task<bool> AddItemAsync(Movie item)
        {
            throw new NotImplementedException();
        }

        public async Task<IDictionary<int, Genre>> GetGenresAsync()
        {
            var result = MockValues.GetGenres();

            return await Task.FromResult(result.genres.ToDictionary(x => x.Id));
        }

        public Task<Movie> GetItemAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<MoviesResult> GetUpcomingMoviesAsync(int page)
        {
            return Task.FromResult(MockValues.GetUpcomingMovies());
        }

        public Task InitializeAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> PullLatestAsync()
        {
            throw new NotImplementedException();
        }

        public Task<MoviesResult> SearchAsync(string searchText, int page)
        {
            var result = MockValues.GetSearchMovies();
            var list = result.results.Where(x => x.MovieName.Contains(searchText)).ToList();
            if(list.Any())
                return Task.FromResult(result);
            else
                return Task.FromResult(new MoviesResult() { page = 1, results = new List<Movie>(), total_results = 0, total_pages=1});
        }

        public Task<bool> SyncAsync()
        {
            throw new NotImplementedException();
        }
    }
}
