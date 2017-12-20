using System.Threading.Tasks;
using System.Windows.Input;
using TMDbApp.Services;
using Xamarin.Forms;

namespace TMDbApp.ViewModels
{
    public class UpcomingMoviesViewModel : BaseMovieViewModel, IUpcomingMoviesViewModel
    {
        public ICommand LoadItemsCommand { get; set; }
        public ICommand SearchCommand => new Command(NavigateToSearchAsync);
        public ICommand SelectedItemCommand => new Command(NavigateToMovieAsync);

        public UpcomingMoviesViewModel(IMovieService movieService): base(movieService)
        {
            LoadItemsCommand = new Command(async
                () => await LoadMoviesAsync(),
                () => {return CurrentPage < TotalPages;});

            LoadMoviesAsync().ConfigureAwait(false);
        }

        private async Task LoadMoviesAsync()
        {
            IsBusy = true;
            var result = await MovieService.GetUpcomingMoviesAsync(CurrentPage++);
            TotalPages = result.Total_Pages;
            Device.BeginInvokeOnMainThread(() =>
            {
                foreach (var item in result.Results)
                {
                    Movies.Add(new MovieDetailViewModel(item));
                }
            });
            IsBusy = false;
        }
        private async void NavigateToMovieAsync(object movieDetail)
        {
            var viewModel = movieDetail as MovieDetailViewModel;
            await PushAsync<MovieDetailViewModel>(viewModel);
        }

        private async void NavigateToSearchAsync()
        {
            await PushAsync<MovieSearchViewModel>();
        }
    }
}