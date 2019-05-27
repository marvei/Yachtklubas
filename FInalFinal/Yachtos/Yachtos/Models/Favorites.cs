using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Yachtos.Models
{
    public class Favorites
    {
        public int FavoritesId { get; set; }
        [ForeignKey("id")]
        public int ItemsId { get; set; }
        [ForeignKey("id")]
        public int UserId { get; set; }

    }
}
