using System.Collections.Generic;
using System.Threading.Tasks;
using TMDbApp.Models;

namespace TMDbApp.Services
{
    public interface IMovieService<T>
    {
        Task<bool> AddItemAsync(T item);
        Task<T> GetItemAsync(string id);
        Task<MoviesResult> GetUpcomingMoviesAsync(int page);
        Task<MoviesResult> SearchAsync(string searchText, int page);

        Task<IDictionary<int, Genre>> GetGenresAsync();

        Task InitializeAsync();
        Task<bool> PullLatestAsync();
        Task<bool> SyncAsync();
    }
}
