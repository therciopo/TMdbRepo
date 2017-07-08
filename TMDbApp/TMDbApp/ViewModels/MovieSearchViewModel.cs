using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Input;
using TMDbApp.Services;
using Xamarin.Forms;

namespace TMDbApp.ViewModels
{
    public class MovieSearchViewModel : BaseMovieViewModel, INotifyPropertyChanged, IMovieSearchViewModel
    {
        public ICommand LoadCommand { get; set; }
        public ICommand SearchCommand { get; set; }
        public ICommand SelectedItemCommand => new Command(NavigateToMovieAsync);
        private string _searchText;
        public string SearchText
        {
            get { return _searchText; }
            set { if (_searchText != value) { _searchText = value; OnPropertyChanged(); } }
        }

        public MovieSearchViewModel(IMovieService movieService) : base(movieService)
        {
            LoadCommand = new Command(async ()=>
            await LoadMoviesAsync(),
            () => CanLoadCommand());

            SearchCommand = new Command(async () =>
            {
                CurrentPage = 1;
                await LoadMoviesAsync(clearList: true);
            },
            () => { return !IsBusy; });
        }
        private bool CanLoadCommand()
        {
            return (!IsBusy) &&
                ((TotalPages == 0) || (CurrentPage < TotalPages));
        }

        private async Task LoadMoviesAsync(bool clearList=false)
        {
            if (IsBusy)
                return;

            IsBusy = true;

            var moviesResult = await MovieService.SearchAsync(SearchText, CurrentPage++);
            TotalPages = moviesResult.Total_Pages;
            Device.BeginInvokeOnMainThread(() =>
            {
                if (clearList) Movies.Clear();
                foreach (var item in moviesResult.Results)
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
    }
}
