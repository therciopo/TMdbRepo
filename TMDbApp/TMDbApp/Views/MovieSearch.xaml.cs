using Autofac;
using TMDbApp.Models;
using TMDbApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TMDbApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchPage : ContentPage
    {
        private ISearchViewModel _viewModel;
        public SearchPage()
        {
            InitializeComponent();
            _viewModel = AppContainer.Container.Resolve<ISearchViewModel>();
            BindingContext = _viewModel;

            _viewModel.SearchText = null;
            ClearSearch();

            MySearchBar.TextChanged += (sender, e) =>
            {
                var textChanged = sender as SearchBar;
                ClearSearch();
            };
        }

        private void ClearSearch()
        {
            _viewModel.Movies.Clear();
            _viewModel.TotalPages = 0;
            _viewModel.CurrentPage = 1;
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as Movie;
            if (item == null)
                return;

            await Navigation.PushAsync(new MovieDetailPage(new MovieDetailViewModel(item)));

            ItemsListView.SelectedItem = null;
        }
    }
}