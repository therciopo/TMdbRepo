using TMDbApp.Helpers;
using TMDbApp.Services;

namespace TMDbApp.ViewModels
{
    public interface IBaseMovieViewModel
    {
        ObservableRangeCollection<MovieDetailViewModel> Movies { get; set; }
        IMovieService MovieService { get; set; }
    }
}