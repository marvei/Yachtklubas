using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Yachtos.Models
{
    public class PackagesItems
    {
        public int id { get; set; }
        public Packages Fk_packages { get; set; }
        public Items Fk_item { get; set; }
    }
}
