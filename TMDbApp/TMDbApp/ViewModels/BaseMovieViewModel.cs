using TMDbApp.Helpers;
using TMDbApp.Services;

namespace TMDbApp.ViewModels
{
    public class BaseMovieViewModel : BaseViewModel, IBaseMovieViewModel
    {
        public int TotalPages { get; set; } = 0;
        public int CurrentPage { get; set; } = 1;

        public ObservableRangeCollection<MovieDetailViewModel> Movies { get; set; }
        public IMovieService MovieService { get; set; }
        public BaseMovieViewModel(IMovieService movieService)
        {
            MovieService = movieService;
            Movies = new ObservableRangeCollection<MovieDetailViewModel>();
        }
    }
}