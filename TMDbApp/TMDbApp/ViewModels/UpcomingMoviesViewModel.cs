using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;
using TMDbApp.Models;
using TMDbApp.Services;
using Xamarin.Forms;

namespace TMDbApp.ViewModels
{
    public class UpcomingMoviesViewModel : BaseMovieViewModel, IUpcomingMoviesViewModel
    {
        public ICommand LoadItemsCommand { get; set; }

        public UpcomingMoviesViewModel(IMovieService<Movie> service): base(service)
        {
            Title = "TMDb";

            LoadItemsCommand = new Command(
                async () => await ExecuteLoadItemsCommand(),
                () =>CanExecuteLoadItemsCommand());
        }

        public bool CanExecuteLoadItemsCommand()
        {
            return (CurrentPage < TotalPages);
        }

        async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;
            try
            {
                await GetGenresAsync();

                var result = await MovieService.GetUpcomingMoviesAsync(CurrentPage++);
                TotalPages = result.total_pages;
                foreach (var item in result.results)
                {
                    ConverToGenreNames(item);
                    Movies.Add(item);
                }
            }
            catch (Exception ex)
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
    }
}