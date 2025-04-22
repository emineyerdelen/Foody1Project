using FoodyProject.DataAccessLayer.Abstract;
using FoodyProject.DataAccessLayer.Concrete;
using FoodyProject.DataAccessLayer.Repositories;
using FoodyProject.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodyProject.DataAccessLayer.EntityFramework
{
    public class EfOrderDal:GenericRepository<Order>, IOrderDal
    {
        public EfOrderDal(FoodyContext context) : base(context)
        {
        }

        public int ActiveOrderCount()
        {
            using var context = new FoodyContext();
            return context.Orders.Where(x => x.Description == "Sipariş Alındı").Count();
        }

        public decimal LastOrderPrice()
        {
            using var context = new FoodyContext();
            return context.Orders.OrderByDescending(x => x.OrderID).Take(1).Select(y => y.TotalPrice).FirstOrDefault();
        }

        public int TotalOrderCount()
        {
            using var context = new FoodyContext();
            return context.Orders.Count();
        }
    }
}
