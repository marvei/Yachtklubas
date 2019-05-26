using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

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
    }
}
