using Autofac;
using TMDbApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TMDbApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MovieSearchView : ContentPage
    {
        private IMovieSearchViewModel _viewModel;
        public MovieSearchView()
        {
            InitializeComponent();
            _viewModel = AppContainer.Container.Resolve<IMovieSearchViewModel>();
            BindingContext = _viewModel;

            //_viewModel.SearchText = null;
            //ClearSearch();

            /*MySearchBar.TextChanged += (sender, e) =>
            {
                var textChanged = sender as SearchBar;
                ClearSearch();
            };*/
        }

        /*private void ClearSearch()
        {
            _viewModel.Movies.Clear();
            _viewModel.TotalPages = 0;
            _viewModel.CurrentPage = 1;
        }*/
    }
}