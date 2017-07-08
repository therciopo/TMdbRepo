using Microsoft.VisualStudio.TestTools.UnitTesting;
using TMDbApp.ViewModels;

namespace UnitTestProject1
{
    [TestClass]
    public class UpcomingMoviesTests
    {
        [TestMethod]
        public void MoviesCountShouldBe20()
        {
            Xamarin.Forms.Mocks.MockForms.Init();

            var vm = new UpcomingMoviesViewModel(new MovieServiceMock());

            Assert.IsTrue(vm.Movies.Count == 20, "Movies count != 20");
            Assert.IsTrue(vm.CurrentPage == 2, "Current != 2");

            vm.LoadItemsCommand.Execute(null);
            Assert.IsTrue(vm.CurrentPage == 3, "Current != 3");
        }
        [TestMethod]
        public void TestUpcomingPageNavigation()
        {
            Xamarin.Forms.Mocks.MockForms.Init();

            var vm = new UpcomingMoviesViewModel(new MovieServiceMock());
            Assert.IsTrue(vm.CurrentPage == 2, "Current != 2");

            vm.LoadItemsCommand.Execute(null);
            Assert.IsTrue(vm.CurrentPage == 3, "Current != 3");

            vm.LoadItemsCommand.Execute(null);
            Assert.IsTrue(vm.CurrentPage == 4, "Current != 4");
        }
    }
}
