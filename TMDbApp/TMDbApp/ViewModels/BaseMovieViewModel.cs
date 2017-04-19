using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TMDbApp.Helpers;
using TMDbApp.Models;
using TMDbApp.Services;
using Xamarin.Forms;

namespace TMDbApp.ViewModels
{
    public class BaseMovieViewModel : BaseViewModel, IBaseMovieViewModel
    {
        public int TotalPages { get; set; } = 0;
        public int CurrentPage { get; set; } = 1;

        public ObservableRangeCollection<Movie> Movies { get; set; }
        public IMovieService<Movie> MovieService { get; set; }
        public BaseMovieViewModel(IMovieService<Movie> service)
        {
            MovieService = service;
            Movies = new ObservableRangeCollection<Movie>();
        }

        public async Task GetGenresAsync()
        {
            try
            {
                // refactor to use device cache using Akavache
                if (Constants.genres == null || !Constants.genres.Any())
                    Constants.genres = await MovieService.GetGenresAsync();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                await Application.Current.MainPage
                    .DisplayAlert("Error!", ex.Message, "OK");
            }
        }
        protected void ConverToGenreNames(Movie item)
        {
            foreach (var key in item.GenresIds)
            {
                // refactor
                if (Constants.genres.ContainsKey(key))
                    item.Genres.Add(Constants.genres[key].Name);
            }
        }

    }
}