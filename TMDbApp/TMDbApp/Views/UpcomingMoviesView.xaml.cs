using Autofac;
using TMDbApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TMDbApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UpcomingMoviesView : ContentPage
    {
        private IUpcomingMoviesViewModel _viewModel;

        public UpcomingMoviesView()
        {
            InitializeComponent();

            _viewModel = AppContainer.Container.Resolve<IUpcomingMoviesViewModel>();
            BindingContext = _viewModel;
        }
    }
}
