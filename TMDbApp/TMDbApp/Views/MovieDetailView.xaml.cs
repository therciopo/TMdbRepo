using TMDbApp.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TMDbApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MovieDetailView : ContentPage
    {
        public MovieDetailView()
        {
            InitializeComponent();
        }

        public MovieDetailView(IMovieDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = viewModel;
        }
    }
}
