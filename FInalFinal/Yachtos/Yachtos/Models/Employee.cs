using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yachtos.Database;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace Yachtos.Models
{
    public class Employee
    {
        public string EmployeeId { get; set; }


        public virtual User fk_User { get; set; }

        [ForeignKey("id")]
        public int UserId { get; set; }


        public List<Employee> GetEmployee()
        {
            List<Employee> Listas = new List<Employee>();
            using (var db = new DatabaseContext())
            {
                foreach (var item in db.Employee)
                {
                    Listas.Add(new Employee
                    {
                        EmployeeId = this.EmployeeId,
                        fk_User = this.fk_User
                    }) ;
                }
            }
            return Listas;
        }

        public List<User> GetUsers()
        {
            List<User> users = new List<User>();
            using (var db = new DatabaseContext())
            {
                foreach (var item in db.User)
                {
                    users.Add(new User
                    {
                        Id = item.Id,
                        Username = item.Username,
                        Password = item.Password,
                        Teises = item.Teises,
                        Email = item.Email
                    });
                }
            }
            return users;
        }

        public User getUserById(int? id)
        {
            User temp = new User();
            using (var db = new DatabaseContext())
            {
                temp = db.User.Find(id);
            }
            Console.WriteLine(temp);
            return temp;
        }

        public void Create(int id)
        {
            User temp = getUserById(id);

            using (var db = new DatabaseContext())
            {
                db.Employee.Add(new Employee { EmployeeId = this.EmployeeId, UserId = id });

                db.SaveChanges();
            }
        }

        public Employee GetEmployee(string id)
        {
            Employee emp = new Employee();
            using (var db = new DatabaseContext())
            {
                foreach (var item in db.Employee)
                {
                    if (item.EmployeeId == id)
                    {
                        emp = item;
                    }
                }
            }
            return emp;
        }

        public void DeleteEmployeeById(string id)
        {
            using (var db = new DatabaseContext())
            {
                foreach (var item in db.Employee)
                {
                    if (item.EmployeeId == id)
                    {
                        db.Employee.Remove(item);
                        db.SaveChanges();
                    }
                }
            }
        }
    }
}
