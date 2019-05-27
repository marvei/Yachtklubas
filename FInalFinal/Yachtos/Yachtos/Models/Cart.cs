using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Yachtos.Database;

namespace Yachtos.Models
{
    public class Cart
    {
        public int CartId { get; set; }
        public List<Items> Items { get; set; }
        [ForeignKey("Id")]
        public int ItemsId { get; set; }


        public List<Cart> getCarts()
        {
            List<Cart> Listas = new List<Cart>();
            using (var db = new DatabaseContext())
            {
                foreach (var item in db.Cart)
                {
                    Listas.Add(new Cart { CartId = item.CartId, ItemsId = item.ItemsId });
                }
            }
            return Listas;
        }

        public List<Items> GetItems()
        {
            List<Items> Listas = new List<Items>();
            using (var db = new DatabaseContext())
            {
                foreach (var item in db.Items)
                {
                    Listas.Add(new Items
                    {
                        StorageId = item.StorageId,
                        price = item.price
                    });
                }
            }
            return Listas;
        }

        public Storage getItemInfo(int id)
        {
            Storage temp = new Storage();
            using (var db = new DatabaseContext())
            {
                temp = db.Storage.Find(id);
            }
            return temp;
        }

        public Items getItemPrice(int id)
        {
            Items temp = new Items();
            using (var db = new DatabaseContext())
            {
                temp = db.Items.Find(id);
            }
            return temp;
        }

        public void Create()
        {
            using (var db = new DatabaseContext())
            {
                db.Cart.Add(new Cart { ItemsId = this.ItemsId });
                db.SaveChanges();
            }
        }

        public void Update()
        {
            Cart cart = new Cart();
            cart.ItemsId = ItemsId;
            using (var db = new DatabaseContext())
            {
                db.Cart.Add(new Cart { ItemsId = cart.ItemsId });
                db.SaveChanges();
            }

        }
    }
}
