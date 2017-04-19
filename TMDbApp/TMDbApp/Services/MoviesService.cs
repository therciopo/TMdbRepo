using Newtonsoft.Json;
using System;
using System.Reactive.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TMDbApp.Models;
using System.Diagnostics;
using Xamarin.Forms;

namespace TMDbApp.Services
{
    public class MoviesService : IMovieService<Movie>
    {
        private HttpClient _client;
        private readonly ICacheService _cache;
        public MoviesService(ICacheService cache)
        {
            _cache = cache;
            _client = new HttpClient();
            _client.MaxResponseContentBufferSize = 256000;
        }

        public async Task<bool> AddItemAsync(Movie item)
        {
            return await Task.FromResult(true);
        }

        public async Task<Movie> GetItemAsync(string id)
        {
            return await Task.FromResult(default(Movie));
        }

        public async Task<IDictionary<int, Genre>> GetGenresAsync()
        {
            var uri = new Uri($"{Constants.apiBaseUrl}/genre/movie/list?api_key={Constants.apiKey}&language={Constants.language}");

            var response = await _client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<GenreResult>(content);

                return await Task.FromResult(result.genres.ToDictionary(x => x.Id));
            }
            else
            {
                return await Task.FromResult(default(IDictionary<int, Genre>));
            }
        }

        public async Task<MoviesResult> GetUpcomingMoviesAsync(int page = 1)
        {
            var uri = page == 1 ?
                new Uri($"{Constants.apiBaseUrl}/movie/upcoming?api_key={Constants.apiKey}&language={Constants.language}") :
                new Uri($"{Constants.apiBaseUrl}/movie/upcoming?api_key={Constants.apiKey}&language={Constants.language}&page={page}");

            var response = await _client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var jsonObject = JsonConvert.DeserializeObject<MoviesResult>(content);
                return await Task.FromResult(jsonObject);
            }
            else
            {
                return await Task.FromResult(default(MoviesResult));
            }
        }

        public async Task<MoviesResult> SearchAsync(string searchText, int page = 1)
        {
            var uri = page == 1 ?
                new Uri($"{Constants.apiBaseUrl}/search/movie/?api_key={Constants.apiKey}&query={searchText}") :
                new Uri($"{Constants.apiBaseUrl}/search/movie/?api_key={Constants.apiKey}&query={searchText}&page={page}");

            try
            {
                var response = await _client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var jsonObject = JsonConvert.DeserializeObject<MoviesResult>(content);
                    return await Task.FromResult(jsonObject);
                }
                else
                {
                    return await Task.FromResult(default(MoviesResult));
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                await Application.Current.MainPage
                    .DisplayAlert("Error!", ex.Message, "OK");

                return await Task.FromResult(default(MoviesResult));
            }
        }

        public Task InitializeAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> PullLatestAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> SyncAsync()
        {
            throw new NotImplementedException();
        }
    }
}
