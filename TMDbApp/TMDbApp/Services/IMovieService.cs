using System.Threading.Tasks;
using TMDbApp.Models;

namespace TMDbApp.Services
{
    public interface IMovieService
    {
        Task<MoviesResult> GetUpcomingMoviesAsync(int page);
        Task<MoviesResult> SearchAsync(string searchText, int page);
    }
}
