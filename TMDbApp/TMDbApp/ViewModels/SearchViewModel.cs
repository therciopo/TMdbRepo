using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;
using TMDbApp.Models;
using TMDbApp.Services;
using Xamarin.Forms;

namespace TMDbApp.ViewModels
{
    public class SearchViewModel : BaseMovieViewModel, INotifyPropertyChanged, ISearchViewModel
    {
        public ICommand SearchCommand { get; set; }

        private string _searchText;
        public string SearchText
        {
            get { return _searchText; }
            set { if (_searchText != value) { _searchText = value; OnPropertyChanged(); } }
        }

        public SearchViewModel(IMovieService<Movie> service) : base(service)
        {
            Title = "Search Movies";

            SearchCommand = new Command(
                async () => await DoSearchCommand(),
                () => CanExecuteSearchCommand());
        }

        private async Task DoSearchCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;
            try
            {
                await GetGenresAsync();

                var result = await MovieService.SearchAsync(SearchText, CurrentPage++);
                TotalPages = result.total_pages;
                foreach (var item in result.results)
                {
                    ConverToGenreNames(item);
                    Movies.Add(item);
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex);
                await Application.Current.MainPage
                    .DisplayAlert("Error!", ex.Message, "OK");
            }
            finally
            {
                IsBusy = false;
            }
        }
        private bool CanExecuteSearchCommand()
        {
            return (!IsBusy) &&
                ((TotalPages==0) || (CurrentPage < TotalPages));
        }
    }
}
