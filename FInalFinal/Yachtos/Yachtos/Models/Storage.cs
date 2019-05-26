using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yachtos.Database;

namespace Yachtos.Models
{
    public class Storage
    {
        public int id { get; set; }
        public string Item { get; set; }
        public string description { get; set; }
        public string Image { get; set; }
        public int kiekis { get; set; }

        public List<Storage> GetStorage()
        {
            List<Storage> Listas = new List<Storage>();
            using (var db = new DatabaseContext())
            {
                foreach (var item in db.Storage)
                {
                    Listas.Add(new Storage
                    {
                        id = item.id,
                        Item = item.Item,
                        description = item.description,
                        Image = item.Image,
                        kiekis = item.kiekis
                    });
                }
            }
            return Listas;
        }
        public void Create()
        {
            using (var db = new DatabaseContext())
            {
                db.Storage.Add(new Storage { id = this.id, description = this.description, Image = this.Image, kiekis = this.kiekis ,Item = this.Item});
                db.SaveChanges();
            }
        }

        public Storage GetPoll(int? id)
        {
            Storage stor = new Storage();
            using (var db = new DatabaseContext())
            {
                foreach (var item in db.Storage)
                {
                    if(item.id == id)
                    {
                        stor = item;
                    }
                }
            }
            return stor;
        }

        public void DeletePollById(int id)
        {
            using (var db = new DatabaseContext())
            {
                foreach(var item in db.Storage)
                {
                    if(item.id == id)
                    {
                        db.Storage.Remove(item);
                        db.SaveChanges();
                    }
                }
            }
        }
        public void Update()
        {
            Storage temp = new Storage();
            temp.id = id;
            temp.Image = Image;
            temp.Item = Item;
            temp.kiekis = kiekis;
            temp.description = description;
            using (var db = new DatabaseContext())
            {
                foreach (var item in db.Storage)
                {
                    if(item.id == id)
                    {
                        item.Image = temp.Image;
                        item.Item = temp.Item;
                        item.kiekis = temp.kiekis;
                        item.description = temp.description;
                        db.Storage.Update(item);
                        db.SaveChanges();

                    }
                }
            }
        }
    }
}
