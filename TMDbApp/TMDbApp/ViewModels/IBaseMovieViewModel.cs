using TMDbApp.Helpers;
using TMDbApp.Models;
using TMDbApp.Services;

namespace TMDbApp.ViewModels
{
    public interface IBaseMovieViewModel
    {
        ObservableRangeCollection<Movie> Movies { get; set; }
        IMovieService<Movie> MovieService { get; set; }
    }
}