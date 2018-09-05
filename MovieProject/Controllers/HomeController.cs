using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieProject.Models;
using System.Globalization;

namespace MovieProject.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        private MovieUserDataContext db = new MovieUserDataContext();
        public ActionResult Index()
        {
            if (Session["FullName"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public ActionResult Movie()
        {
            MovieModel mod = new MovieModel();
            ViewBag.MovieData = mod.GetMovieData();
            ViewBag.GenreMovieListData = mod.GetGenreMovieData();
            return View(ViewBag);
        }
        [HttpPost]
        public ActionResult Movie(FormCollection col)
        {
            MovieUserDataContext db = new MovieUserDataContext();
            Movie moviedata = new Movie();
            string moviename = col.Get("moviename");
            string releaseyear = col.Get("releaseyear");
            string genre = col.Get("genre");

            if (moviename == "")
            {
                return Json(new { status = 0, message = "Movie Name harus diisi" }, JsonRequestBehavior.AllowGet);
            }
            else if (releaseyear == "")
            {
                return Json(new { status = 0, message = "Release Year harus diisi" }, JsonRequestBehavior.AllowGet);
            }
            else if (genre == "")
            {
                return Json(new { status = 0, message = "Genre harus dipilih" }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                moviedata.MovieName = moviename;
                moviedata.ReleaseYear = DateTime.Parse(releaseyear);
                moviedata.GenreID = Int32.Parse(genre);

                db.Movies.InsertOnSubmit(moviedata);
                db.SubmitChanges();
                return Json(new { status = 1, message = "Berhasil Input Movie" }, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult DeleteMovie(int movieid)
        {
            var data = (from m in db.Movies where m.MovieID == movieid select m).First();
            db.Movies.DeleteOnSubmit(data);
            db.SubmitChanges();
            return RedirectToAction("Movie");
        }

        public ActionResult Pengguna()
        {

            UserModel mod = new UserModel();
            ViewBag.UserData = mod.GetUserData();
            return View(ViewBag);
        }
        [HttpPost]
        public ActionResult Pengguna(FormCollection col)
        {
            MovieUserDataContext db = new MovieUserDataContext();
            Pengguna userdata = new Pengguna();
            string username = col.Get("username");
            string fullname = col.Get("fullname");
            string password = col.Get("password");
            if (username == "")
            {
                return Json(new { status = 0, message = "User Name harus diisi" }, JsonRequestBehavior.AllowGet);
            }
            else if (fullname == "")
            {
                return Json(new { status = 0, message = "Full Name harus diisi"}, JsonRequestBehavior.AllowGet);
            }
            else if (password == "")
            {
                return Json(new { status = 0, message = "Password harus diisi" }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                userdata.UserName = username;
                userdata.FullName = fullname;
                userdata.Password = password;
                userdata.CreatedOn = DateTime.Now;
                db.Penggunas.InsertOnSubmit(userdata);
                db.SubmitChanges();
                return Json(new { status = 1, message = "Berhasil Input User" }, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult DeleteUser(string username)
        {
            var datauser = (from u in db.Penggunas where u.UserName == username select u).SingleOrDefault();
            db.Penggunas.DeleteOnSubmit(datauser);
            db.SubmitChanges();
            return RedirectToAction("Pengguna");
        }

        public ActionResult Collection()
        {
            string username = Convert.ToString(Session["UserName"]);
            if (Session["UserName"] != null)
            {
                CollectionModel mod = new CollectionModel();
                ViewBag.CollectionData = mod.GetCollectionData(username);
                ViewBag.MovieCollectionData = mod.GetMovieCollection();
                return View(ViewBag);
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        [HttpPost]
        public ActionResult Collection(FormCollection col)
        {
            MovieUserDataContext db = new MovieUserDataContext();
            Collection collectiondata = new Collection();
            string moviecol = col.Get("moviecol");

            CollectionModel cm = new CollectionModel();
            bool moviec = cm.ValidateCollectionMovie(moviecol);
            if (moviec == false)
            {
                return Json(new { status = 0, message = "Movie harus ada di list" }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                collectiondata.UserName = Convert.ToString(Session["UserName"]);
                collectiondata.MovieID = Int32.Parse(moviecol);
                collectiondata.CreatedOnCollection = DateTime.Now;

                db.Collections.InsertOnSubmit(collectiondata);
                db.SubmitChanges();
                return Json(new { status = 1, message = "Berhasil Input Movie" }, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult DeleteCollection(int collectionid)
        {
            var data = (from c in db.Collections where c.CollectionID == collectionid select c).First();
            db.Collections.DeleteOnSubmit(data);
            db.SubmitChanges();
            return RedirectToAction("Collection");
        }

        public ActionResult Report()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(FormCollection col)
        {
            string username = col.Get("username");
            string password = col.Get("pwd");

            UserModel um = new UserModel();
            Tuple<bool, string> user = um.ValidateLogin(username, password);
            if (user.Item1 == false)
            {
                return Json(new { status = 0, message = "User Name atau Password Salah" }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                Session["UserName"] = username.ToString();
                Session["FullName"] = user.Item2.ToString();
                return Json(new { status = 1, message = "Berhasil Login" }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}
