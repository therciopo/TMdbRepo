using System.Windows.Input;
using TMDbApp.Helpers;
using TMDbApp.Models;

namespace TMDbApp.ViewModels
{
    public interface ISearchViewModel
    {
        ObservableRangeCollection<Movie> Movies { get; set; }
        ICommand SearchCommand { get; set; }

        string SearchText { get; set; }
        int TotalPages { get; set; }
        int CurrentPage { get; set; }
    }
}