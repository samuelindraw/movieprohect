using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Web;

namespace MovieProject.Models
{
    public class UserModel
    {
        public string username { get; set; }
        public string fullname { get; set; }
        public string password { get; set; }
        public DateTime createdonuser { get; set; }

        private MovieUserDataContext db = new MovieUserDataContext();
        public List<Pengguna> GetUserData()
        {
            List<Pengguna> UserList = new List<Pengguna>();
            UserList = db.Penggunas.ToList();
            return UserList;
        }

        public Tuple<bool, string> ValidateLogin(string username, string password)
        {
            var obj = db.Penggunas.Where(a => a.UserName.Equals(username) && a.Password.Equals(password));
            if(obj.Count() == 1)
            {
                return new Tuple<bool, string>(true, obj.SingleOrDefault().FullName);
            }
            return new Tuple<bool, string>(false, string.Empty);
        }
    }

}