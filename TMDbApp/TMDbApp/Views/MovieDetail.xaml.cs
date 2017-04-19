using TMDbApp.ViewModels;

using Xamarin.Forms;

namespace TMDbApp.Views
{
    public partial class MovieDetailPage : ContentPage
    {
        IMovieDetailViewModel viewModel;

        // Note - The Xamarin.Forms Previewer requires a default, parameterless constructor to render a page.
        public MovieDetailPage()
        {
            InitializeComponent();
        }

        public MovieDetailPage(IMovieDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }
    }
}
