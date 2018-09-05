using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieProject.Models
{
    public class GenreModel
    {
        public int genreid { get; set; }
        public string genrename { get; set; }

        private MovieUserDataContext db = new MovieUserDataContext();
        public List<Genre> GetGenreData()
        {
            List<Genre> GenreList = new List<Genre>();
            GenreList = db.Genres.ToList();
            return GenreList;
        }
    }
}