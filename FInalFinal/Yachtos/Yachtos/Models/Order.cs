using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yachtos.Database;

namespace Yachtos.Models
{
    public class Order
    {
        public int id { get; set; }
        public double price { get; set; }
        public string descprition { get; set; }
        public string busena { get; set; }

        public List<Order> GetOrder()
        {
            List<Order> Listas = new List<Order>();
            using (var db = new DatabaseContext())
            {
                foreach (var item in db.Order)
                {
                    Listas.Add(new Order
                    {
                        id = item.id,
                        price = item.price,
                        descprition = item.descprition,
                        busena = item.busena
                    });
                }
            }
            return Listas;
        }

        public void Create()
        {
            using (var db = new DatabaseContext())
            {
                db.Order.Add(new Order { id = this.id, descprition = this.descprition, price = this.price, busena = this.busena });
                db.SaveChanges();
            }
        }

        public void Update()
        {
            Order order = new Order();
            order.id = id;
            order.descprition = descprition;
            using (var db = new DatabaseContext())
            {
                foreach (var item in db.Order)
                {
                    if (item.id == id)
                    {
                        item.descprition = order.descprition;
                        db.Order.Update(item);
                        db.SaveChanges();

                    }
                }
            }

        }


        public Order GetOrder(int? id)
        {
            Order emp = new Order();
            using (var db = new DatabaseContext())
            {
                foreach (var item in db.Order)
                {
                    if (item.id == id)
                    {
                        emp = item;
                    }
                }
            }
            return emp;
        }
    }
}
