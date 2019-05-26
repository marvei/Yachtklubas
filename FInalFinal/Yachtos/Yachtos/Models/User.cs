using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yachtos.Database;

namespace Yachtos.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int Id { get; set; }
        public int Teises { get; set; }
        public string Email { get; set; }

        public List<User> GetUsers()
        {
            List<User> Listas = new List<User>();
            using (var db = new DatabaseContext())
            {
                foreach(var item in db.User)
                {
                    Listas.Add(new User
                    {
                        Id = item.Id,
                    Username = item.Username,
                    Password = item.Password,
                    Teises = item.Teises,
                    Email = item.Email
                    });
                }
            }
            return Listas;
        }

        internal void Create()
        {
            using (var db = new DatabaseContext())
            {
                db.User.Add(new User { Username = this.Username, Password = this.Password, Email = this.Email, Id = this.Id, Teises = this.Teises });
                db.SaveChanges();
            }                

        }
    }
}
