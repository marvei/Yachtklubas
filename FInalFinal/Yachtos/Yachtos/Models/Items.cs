using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yachtos.Database;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace Yachtos.Models
{
    public class Items
    {
        public int id { get; set; }
        public virtual Storage fk_storage { get; set; }
        [ForeignKey("id")]
        public int StorageId { get; set; }

        public double price { get; set; }


        /*public List<Storage> GetItems()
        {
            List<Storage> items = new List<Storage>();
            using (var db = new DatabaseContext())
            {
                foreach (var item in db.Storage)
                {
                    items.Add(new Storage
                    {
                        id = item.id,
                        Item = item.Item,
                        description = item.description,
                        Image = item.Image,
                        kiekis = item.kiekis
                    });
                }
            }
            return items;
        }*/


        public List<Items> GetItem()
        {
            List<Items> Listas = new List<Items>();
            using (var db = new DatabaseContext())
            {
                foreach (var item in db.Items)
                {
                    Listas.Add(new Items
                    {
                        id = item.id,
                        price = item.price,
                        StorageId = item.StorageId
                    });
                }
            }
            return Listas;
        }

        public List<Storage> GetStorages()
        {
            List<Storage> storages = new List<Storage>();
            using (var db = new DatabaseContext())
            {
                foreach (var item in db.Storage)
                {
                    storages.Add(new Storage
                    {
                        Item = item.Item,
                        id = item.id
                    });
                }
            }
            return storages;
        }

        public Storage getStorageById(int id)
        {
            Storage temp = new Storage();
            using (var db = new DatabaseContext())
            {
                temp = db.Storage.Find(id);
            }
            return temp;
        }

        public void Create()
        {
            using (var db = new DatabaseContext())
            {
                db.Items.Add(new Items { id = this.id, price = this.price, StorageId = this.StorageId });
                db.SaveChanges();
            }
        }

        public Items GetItem(int? id)
        {
            Items emp = new Items();
            using (var db = new DatabaseContext())
            {
                foreach (var item in db.Items)
                {
                    if (item.id == id)
                    {
                        emp = item;
                    }
                }
            }
            return emp;
        }

        public void DeleteItemById(int id)
        {
            using (var db = new DatabaseContext())
            {
                foreach (var item in db.Items)
                {
                    if (item.id == id)
                    {
                        db.Items.Remove(item);
                        db.SaveChanges();
                    }
                }
            }
        }
    }
}