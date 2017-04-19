using System;
using Autofac;
using TMDbApp.Models;
using TMDbApp.ViewModels;
using Xamarin.Forms;

namespace TMDbApp.Views
{
    public partial class UpcomingMovies : ContentPage
    {
        private IUpcomingMoviesViewModel _viewModel;

        public UpcomingMovies()
        {
            InitializeComponent();

            _viewModel = AppContainer.Container.Resolve<IUpcomingMoviesViewModel>();
            BindingContext = _viewModel;
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as Movie;
            if (item == null)
                return;

            await Navigation.PushAsync(new MovieDetailPage(new MovieDetailViewModel(item)));
            ItemsListView.SelectedItem = null;
        }

        async void SearchItem_Clicked(object sender, EventArgs e)
        {
            var page = new SearchPage();
            await Navigation.PushAsync(page);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (_viewModel?.Movies.Count == 0)
                _viewModel.LoadItemsCommand.Execute(null);
        }

        private void RefreshItem_Clicked(object sender, EventArgs e)
        {

        }
    }
}
