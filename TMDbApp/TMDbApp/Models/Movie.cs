using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using TMDbApp.Helpers;

namespace TMDbApp.Models
{
    public class Movie : ObservableObject
    {
        public string MovieName { get; set; }

        public List<int> GenresIds { get; set; }

        public List<string> Genres { get; set; } = new List<string>();

        public DateTime? ReleaseDate { get; set; }

        public string Overview { get; set; }

        public string BackDropImage { get; set; }
        public string PosterImage { get; set; }

        public string VoteAverage { get; set; }
    }
}
