using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodyProject.EntityLayer.Entities
{
    public class Basket
    {
  
        public string UserID { get; set; }
        public IdentityUser User { get; set; }
        public int BasketID { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
