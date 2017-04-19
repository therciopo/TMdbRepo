using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using TMDbApp.Helpers;

namespace TMDbApp.Models
{
    public class Movie : ObservableObject
    {
        private string _movieName = string.Empty;
        [JsonProperty("title")]
        public string MovieName
        {
            get { return _movieName; }
            set { SetProperty(ref _movieName, value); }
        }

        private List<int> _genre_ids = new List<int> { };
        [JsonProperty("genre_ids")]
        public List<int> GenresIds
        {
            get { return _genre_ids; }
            set { SetProperty(ref _genre_ids, value); }
        }

        private List<string> _genres = new List<string> { };
        public List<string> Genres
        {
            get { return _genres; }
            set { SetProperty(ref _genres, value); }
        }

        private DateTime? _releaseDate = DateTime.MinValue;
        [JsonProperty("release_date")]
        public DateTime? ReleaseDate
        {
            get { return _releaseDate; }
            set { SetProperty(ref _releaseDate, value); }
        }

        private string _overview = string.Empty;
        public string Overview
        {
            get { return _overview; }
            set { SetProperty(ref _overview, value); }
        }

        private string _backDropImage = string.Empty;
        [JsonProperty("backdrop_path")]
        public string BackDropImage
        {
            get { return $"{Constants.imageBaseUrl}{Constants.image_size}{_backDropImage}"; }
            set { SetProperty(ref _backDropImage, value); }
        }
        private string _posterPath = string.Empty;
        [JsonProperty("poster_path")]
        public string PosterImage
        {
            get { return $"{Constants.imageBaseUrl}{Constants.image_size}{_posterPath}"; }
            set { SetProperty(ref _posterPath, value); }
        }
        private string _vote_avg = string.Empty;
        [JsonProperty("vote_average")]
        public string VoteAverage
        {
            get { return _vote_avg; }
            set { SetProperty(ref _vote_avg, value); }
        }
    }

    // refactor to DTO's
    public class Dates
    {
        public string maximum { get; set; }
        public string minimum { get; set; }
    }
    public class MoviesResult
    {
        public int page { get; set; }
        public List<Movie> results { get; set; }
        public Dates dates { get; set; }
        public int total_pages { get; set; }
        public int total_results { get; set; }
    }
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class GenreResult
    {
        public List<Genre> genres { get; set; }
    }
}
