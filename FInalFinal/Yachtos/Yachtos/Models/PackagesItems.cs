using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Yachtos.Database;

namespace Yachtos.Models
{
    public class PackagesItems
    {
        public int id { get; set; }
        public virtual Packages Fk_packages { get; set; }
        [ForeignKey("Id")]
        public int PackageId { get; set; }
        public virtual Items Fk_item { get; set; }
        [ForeignKey("Id")]
        public int ItemsId { get; set; }

        public List<PackagesItems> GetPackItems()
        {
            List<PackagesItems> items = new List<PackagesItems>();
            using (var db = new DatabaseContext())
            {
                foreach (var item in db.PackagesItems)
                {
                    items.Add(new PackagesItems
                    {
                        id = item.id,
                        PackageId = item.PackageId,
                        ItemsId = item.ItemsId
                    }) ;
                }
            }
            return items;
        }

        //public List<User> GetUsers()
        //{
        //    List<User> users = new List<User>();
        //    using (var db = new DatabaseContext())
        //    {
        //        foreach (var item in db.User)
        //        {
        //            users.Add(new User
        //            {
        //                Username = item.Username,
        //                Id = item.Id
        //            });
        //        }
        //    }
        //    return users;
        //}

        //public User getUserById(int id)
        //{
        //    User temp = new User();
        //    using (var db = new DatabaseContext())
        //    {
        //        temp = db.User.Find(id);
        //    }
        //    return temp;
        //}

        public void Create()
        {
            using (var db = new DatabaseContext())
            {
                db.PackagesItems.Add(new PackagesItems { id = this.id, ItemsId = this.ItemsId, PackageId = this.PackageId });
                db.SaveChanges();
            }
        }

        //public Employee GetEmployee(string id)
        //{
        //    Employee emp = new Employee();
        //    using (var db = new DatabaseContext())
        //    {
        //        foreach (var item in db.Employee)
        //        {
        //            if (item.EmployeeId == id)
        //            {
        //                emp = item;
        //            }
        //        }
        //    }
        //    return emp;
        //}

        //public void DeleteEmployeeById(string id)
        //{
        //    using (var db = new DatabaseContext())
        //    {
        //        foreach (var item in db.Employee)
        //        {
        //            if (item.EmployeeId == id)
        //            {
        //                db.Employee.Remove(item);
        //                db.SaveChanges();
        //            }
        //        }
        //    }
        //}

        public double price;

        //public void getItemTypes()
        //{
        //    List<string> temp = new List<string>();

        //    List<PackagesItems> list = GetPackItems();
           
        //}

        public List<string> getItemTypes()
        {
            List<string> storage = new List<string>();
            using (var db = new DatabaseContext())
            {
                storage = db.Storage.Select(x => x.description).Distinct().ToList();
            }
            return storage;
        }

        public List<Storage> getStorage(string desc)
        {
            List<Storage> temp = new List<Storage>();
            using (var db = new DatabaseContext())
            {
                foreach (var item in db.Storage)
                {
                    if (item.description.Equals(desc))
                    {
                        temp.Add(new Storage { id = item.id, description = item.description, Item = item.Item });

                    }
                }
            }
            return temp;
        }

        public List<Items> getItems()
        {
            List<Items> temp = new List<Items>();
            using (var db = new DatabaseContext())
            {
                foreach (var item in db.Items)
                {
                    temp.Add(new Items
                    {
                        id = item.id,
                        price = item.price,
                        StorageId = item.StorageId

                    }) ;
                }
                
            }
            return temp;
        }
    }

}
