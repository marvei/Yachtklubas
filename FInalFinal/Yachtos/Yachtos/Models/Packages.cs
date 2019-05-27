using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yachtos.Database;

namespace Yachtos.Models
{
    public class Packages
    {
        public int id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }


        public List<Packages> GetPackages()
        {
            List<Packages> items = new List<Packages>();
            using (var db = new DatabaseContext())
            {
                foreach (var item in db.Packages)
                {
                    items.Add(new Packages
                    {
                        id = item.id,
                        Name = item.Name,
                        Price = item.Price

                    }) ;
                }
            }
            return items;
        }
    }
}
