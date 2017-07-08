using System;
using System.Collections.Generic;
using System.Linq;
using TMDbApp.Models;

namespace TMDbApp.Helpers.Extensions
{
    public static class Extensions
    {
        public static Movie ToModel(this Services.DTO.Movie movie, IEnumerable<Services.DTO.Genre> genres)
        {
            var movieModel = new Movie
            {
                MovieName = movie.MovieName,
                Overview = movie.Overview,
                VoteAverage = movie.VoteAverage,
                ReleaseDate = movie.ReleaseDate,
                BackDropImage = movie.BackDropImage,
                PosterImage = movie.PosterImage
            };

            try
            {
                movieModel.Genres = movie.GenresIds.Select(x =>
                {
                    return genres.FirstOrDefault(g => x.Equals(g.Id)).Name;
                }).ToList();
                return movieModel;
            }
            catch (Exception)
            {
                return new Movie
                {
                    MovieName = movie.MovieName,
                    Overview = movie.Overview,
                    VoteAverage = movie.VoteAverage,
                    ReleaseDate = movie.ReleaseDate,
                    BackDropImage = movie.BackDropImage,
                    PosterImage = movie.PosterImage
                };
            }
        }
    }
}
