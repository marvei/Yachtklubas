using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Yachtos.Database;

namespace Yachtos.Models
{
    public class Favorites
    {
        public int FavoritesId { get; set; }
        [ForeignKey("id")]
        public int ItemsId { get; set; }
        [ForeignKey("id")]
        public int UserId { get; set; }

        public List<Favorites> getFavs()
        {
            List<Favorites> Listas = new List<Favorites>();
            using (var db = new DatabaseContext())
            {
                foreach (var item in db.Favorites)
                {
                    Listas.Add(new Favorites { ItemsId = item.ItemsId, FavoritesId = item.FavoritesId, UserId = item.UserId });
                }
            }
            return Listas;
        }

        public Storage getFavoriteById(int id)
        {
            Storage temp = new Storage();
            using (var db = new DatabaseContext())
            {
                temp = db.Storage.Find(id);
            }
            return temp;
        }
    }
}
