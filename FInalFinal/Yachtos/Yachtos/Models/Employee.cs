using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Yachtos.Models
{
    public class Employee
    {
        public string EmployeeId { get; set; }
        public User fk_User { get; set; }
    }
}
