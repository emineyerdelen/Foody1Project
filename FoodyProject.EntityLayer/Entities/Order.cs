using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodyProject.EntityLayer.Entities
{
   public class Order
    {
        public int OrderID { get; set; }
        public string Description { get; set; }
        public DateTime  OrderDate { get; set; }
        public decimal TotalPrice { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
