using Plugin.Connectivity;
using Plugin.Connectivity.Abstractions;
using TMDbApp.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace TMDbApp
{
    public partial class App : Application
    {
        public App(AppSetup setup)
        {
            InitializeComponent();

            AppContainer.Container = setup.CreateContainer();

            var content = new UpcomingMoviesView();
            MainPage = new NavigationPage(content);
        }
        protected override void OnStart()
        {
            CrossConnectivity.Current.ConnectivityChanged += HandleConnectivityChanged;
        }
        void HandleConnectivityChanged(object sender, ConnectivityChangedEventArgs e)
        {
            var currentPage = MainPage.GetType();

            if (e.IsConnected)
            {
                var content = new UpcomingMoviesView();
                MainPage = new NavigationPage(content);
            }
            else if (!e.IsConnected && currentPage != typeof(NoNetworkView))
                MainPage = new NoNetworkView();
        }
    }
}
