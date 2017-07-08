using System.Windows.Input;
using Xamarin.Forms;

namespace TMDbApp.ViewModels
{
    public interface IUpcomingMoviesViewModel : IBaseMovieViewModel
    {
        ICommand LoadItemsCommand { get; set; }
    }
}