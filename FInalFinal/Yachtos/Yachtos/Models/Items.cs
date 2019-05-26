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


        public List<Storage> GetItems()
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
        }
    }
}