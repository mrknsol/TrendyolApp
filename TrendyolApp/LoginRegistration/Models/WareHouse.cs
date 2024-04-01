using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrendyolApp.Models
{
    public class WareHouse
    {
        [Key]
        public int Id { get; set; } 
        [Required, ForeignKey("Goods")]
        public int GoodsId { get; set; }
        public Goods Goods { get; set; }
        [Required]
        public int Count { get; set; }

    }
}
