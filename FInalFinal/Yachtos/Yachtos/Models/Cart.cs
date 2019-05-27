using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Yachtos.Models
{
    public class Cart
    {
        public int CartId { get; set; }
        public List<Items> Items { get; set; }
        [ForeignKey("Id")]
        public int ItemsId { get; set; }
    }
}
