using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using TMDbApp.Models;
using TMDbApp.Helpers.Extensions;

namespace TMDbApp.Services
{
    public class MoviesService : IMovieService
    {
        private HttpClient _client;
        private IEnumerable<DTO.Genre> _genres;
        public MoviesService()
        {
            _client = new HttpClient();
            _client.MaxResponseContentBufferSize = 256000;

            Task.Run(GetGenresAsync);
        }

        public async Task GetGenresAsync()
        {
            var uri = new Uri($"{Constants.apiBaseUrl}/genre/movie/list?api_key={Constants.apiKey}&language={Constants.language}");

            var response = await _client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<DTO.GenreResult>(content);
                _genres = result.genres;
            }
        }

        public async Task<MoviesResult> GetUpcomingMoviesAsync(int page = 1)
        {
            var uri = page == 1 ?
                new Uri($"{Constants.apiBaseUrl}/movie/upcoming?api_key={Constants.apiKey}&language={Constants.language}") :
                new Uri($"{Constants.apiBaseUrl}/movie/upcoming?api_key={Constants.apiKey}&language={Constants.language}&page={page}");

            var result = await GetHttpRequestAsync<DTO.MoviesResult>(uri);

            var movies = new List<Movie>();
            foreach (var movie in result.results)
                movies.Add(movie.ToModel(_genres));

            return new MoviesResult
            {
                Total_Pages = result.total_pages,
                Total_Results = result.total_results,
                Results = movies
            };
        }

        private async Task<TResult> GetHttpRequestAsync<TResult>(Uri uri)
        {
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(uri);
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<TResult>(content);
            }
        }
        public async Task<MoviesResult> SearchAsync(string searchText, int page = 1)
        {
            var uri = page == 1 ?
                new Uri($"{Constants.apiBaseUrl}/search/movie/?api_key={Constants.apiKey}&query={searchText}") :
                new Uri($"{Constants.apiBaseUrl}/search/movie/?api_key={Constants.apiKey}&query={searchText}&page={page}");

            var moviesResult = await GetHttpRequestAsync<DTO.MoviesResult>(uri);

            var movies = new List<Movie>();
            foreach (var movie in moviesResult.results)
                movies.Add(movie.ToModel(_genres));

            return new MoviesResult
            {
                Total_Pages = moviesResult.total_pages,
                Total_Results = moviesResult.total_results,
                Results = movies
            };
        }
    }
}
