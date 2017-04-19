using Autofac;
using TMDbApp.Models;
using TMDbApp.Services;
using TMDbApp.ViewModels;

namespace TMDbApp
{
    public class AppSetup
    {
        public IContainer CreateContainer()
        {
            ContainerBuilder containerBuilder = new ContainerBuilder();

            RegisterDepedencies(containerBuilder);

            return containerBuilder.Build();
        }
        protected virtual void RegisterDepedencies(ContainerBuilder cb)
        {
            cb.RegisterType<MoviesService>().As<IMovieService<Movie>>().SingleInstance();
            cb.RegisterType<CacheService>().As<ICacheService>().SingleInstance();

            cb.RegisterType<UpcomingMoviesViewModel>().As<IUpcomingMoviesViewModel>().SingleInstance();
            cb.RegisterType<SearchViewModel>().As<ISearchViewModel>().SingleInstance();
        }
    }
}
