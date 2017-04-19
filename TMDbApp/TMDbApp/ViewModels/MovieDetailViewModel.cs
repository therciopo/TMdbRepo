using TMDbApp.Models;

namespace TMDbApp.ViewModels
{
    public class MovieDetailViewModel : BaseViewModel, IMovieDetailViewModel
    {
        public Movie Item { get; set; }
        public MovieDetailViewModel(Movie item = null)
        {
            Title = item.MovieName;
            Item = item;
        }
    }
}