using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMDbApp.Models;

namespace TMDbApp
{
    public static class Constants
    {
        public static string apiBaseUrl = "https://api.themoviedb.org/3";
        public static string apiKey = "1f54bd990f1cdfb230adb312546d765d";
        public static string language = "en-US"; // refactor to a localized solution
        public static string imageBaseUrl = "https://image.tmdb.org/t/p/";
        public static string image_size = "w780";

        public static IDictionary<int, Genre> genres;
    }
}
