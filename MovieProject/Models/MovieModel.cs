using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieProject.Models
{
    public class MovieModel
    {
        public int movieid { get; set; }
        public string moviename { get; set; }
        public DateTime releaseyear { get; set; }
        public int genre_id { get; set; }
        private MovieUserDataContext db = new MovieUserDataContext();
        public List<Movie> GetMovieData()
        {
            List<Movie> MovieList = new List<Movie>();
            MovieList = db.Movies.ToList();
            return MovieList;
        }

        public List<Genre> GetGenreMovieData()
        {
            List<Genre> GenreMovieList = new List<Genre>();
            GenreMovieList = db.Genres.ToList();
            return GenreMovieList;
        }
    }
}