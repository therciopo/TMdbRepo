using System;
using System.Collections.Generic;
using TMDbApp.Models;

namespace TMDbApp.ViewModels
{
    public class MovieDetailViewModel : BaseViewModel, IMovieDetailViewModel
    {

        public Movie Movie { get; set; }
        public MovieDetailViewModel(Movie model)
        {
            Title = model.MovieName;
            Movie = model;
        }

        public string MovieName => Movie.MovieName;
        public string BackDropImage => Movie.BackDropImage;
        public string Overview => Movie.Overview;
        public string PosterImage => Movie.PosterImage;
        public DateTime? ReleaseDate => Movie.ReleaseDate;
        public string VoteAverage => Movie.VoteAverage;
        public List<string> Genres => Movie.Genres;
        public List<int> GenresIds => Movie.GenresIds;
    }
}