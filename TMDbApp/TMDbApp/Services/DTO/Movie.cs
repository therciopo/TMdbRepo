using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using TMDbApp.Models;

namespace TMDbApp.Services.DTO
{
    public class Movie
    {
        private string _movieName = string.Empty;
        [JsonProperty("title")]
        public string MovieName
        {
            get { return _movieName; }
            set { _movieName = value; }
        }
        public string Overview { get; set; }

        private DateTime? _releaseDate = DateTime.MinValue;
        [JsonProperty("release_date")]
        public DateTime? ReleaseDate
        {
            get { return _releaseDate; }
            set { _releaseDate = value; }
        }

        private string _backDropImage = string.Empty;
        [JsonProperty("backdrop_path")]
        public string BackDropImage
        {
            get { return $"{Constants.imageBaseUrl}{Constants.image_size}{_backDropImage}"; }
            set { _backDropImage = value; }
        }
        private string _posterPath = string.Empty;
        [JsonProperty("poster_path")]
        public string PosterImage
        {
            get { return $"{Constants.imageBaseUrl}{Constants.image_size}{_posterPath}"; }
            set { _posterPath = value; }
        }

        private List<int> _genre_ids = new List<int> { };
        [JsonProperty("genre_ids")]
        public List<int> GenresIds
        {
            get { return _genre_ids; }
            set { _genre_ids = value; }
        }

        private string _vote_avg = string.Empty;
        [JsonProperty("vote_average")]
        public string VoteAverage
        {
            get { return _vote_avg; }
            set { _vote_avg = value; }
        }
    }
}
