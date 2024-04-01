using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrendyolApp.Models
{
    public class LikedProducts
    {
        [Key]
        public int Id { get; set; }
        [Required, ForeignKey("Goods")]
        public int GoodsId { get; set; }
        public Goods Goods { get; set; }
        [Required, ForeignKey("Users")]
        public int UserId { get; set; }
        public User Users { get; set; }
    }
}
