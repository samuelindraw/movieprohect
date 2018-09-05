using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieProject.Models
{
    public class CollectionModel
    {
        public int collectionid { get; set; }
        public int movie_id { get; set; }
        public string user_name { get; set; }
        public DateTime createdoncollection { get; set; }
        private MovieUserDataContext db = new MovieUserDataContext();
        public List<Collection> GetCollectionData(string username)
        {
            List<Collection> CollectionList = new List<Collection>();
            CollectionList = db.Collections.Where(a => a.UserName.Equals(username)).ToList();
            return CollectionList;
        }

        public List<Pengguna> GetPenggunaCollection()
        {
            List<Pengguna> PenggunaCollectionList = new List<Pengguna>();
            PenggunaCollectionList = db.Penggunas.ToList();
            return PenggunaCollectionList;
        }

        public List<Movie> GetMovieCollection()
        {
            List<Movie> MovieCollectionList = new List<Movie>();
            MovieCollectionList = db.Movies.ToList();
            return MovieCollectionList;
        }

        public bool ValidateCollectionMovie(string moviecol)
        {
            var obj = db.Movies.Where(a => a.MovieID.Equals(moviecol)).Count();
            if (obj == 1)
            {
                return true;
            }
            return false;
        }
    }
}