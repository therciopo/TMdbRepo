using Microsoft.VisualStudio.TestTools.UnitTesting;
using TMDbApp.ViewModels;

namespace UnitTestProject1
{
    [TestClass]
    public class SearchMoviesTests
    {
        [TestMethod]
        public void MovieNameShouldMatch()
        {
            Xamarin.Forms.Mocks.MockForms.Init();

            var vm = new MovieSearchViewModel(new MovieServiceMock());
            Assert.IsTrue(vm.CurrentPage == 1, "Current != 1");
            vm.SearchText = "Jack";
            vm.SearchCommand.Execute(null);

            Assert.IsTrue(vm.Movies.Count == 2, "Pages != 2");
        }
        [TestMethod]
        public void MovieSearchEmpty()
        {
            Xamarin.Forms.Mocks.MockForms.Init();

            var vm = new MovieSearchViewModel(new MovieServiceMock());
            Assert.IsTrue(vm.CurrentPage == 1, "Current != 1");
            vm.SearchText = "Lorem ispum";
            vm.SearchCommand.Execute(null);

            Assert.IsTrue(vm.Movies.Count == 0, "Movies found");
        }

        [TestMethod]
        public void TestSearchPageNavigation()
        {
            Xamarin.Forms.Mocks.MockForms.Init();

            var vm = new MovieSearchViewModel(new MovieServiceMock());
            Assert.IsTrue(vm.CurrentPage == 1, "Current != 1");

            if (vm.SearchCommand.CanExecute(null) == true)
            {
                vm.SearchCommand.Execute(null);
                Assert.IsTrue(vm.CurrentPage == 2, "Current != 2");
            }
            if (vm.LoadCommand.CanExecute(null) == true)
            {
                vm.LoadCommand.Execute(null);
                Assert.IsTrue(vm.CurrentPage == 3, "Current != 3");
            }
        }
        [TestMethod]
        public void TestSearchPageNavigationEndReach()
        {
            Xamarin.Forms.Mocks.MockForms.Init();

            var vm = new MovieSearchViewModel(new MovieServiceMock());
            Assert.IsTrue(vm.CurrentPage == 1, "Current != 1");
            vm.SearchText = "Jack";
            if (vm.SearchCommand.CanExecute(null) == true)
            {
                vm.SearchCommand.Execute(null);
                Assert.IsTrue(vm.CurrentPage == 2, "Current != 2");
            }

            Assert.IsTrue(vm.LoadCommand.CanExecute(null) == false, "End not reached");
        }
    }
}
