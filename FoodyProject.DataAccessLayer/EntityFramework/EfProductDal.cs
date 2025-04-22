using FoodyProject.DataAccessLayer.Abstract;
using FoodyProject.DataAccessLayer.Concrete;
using FoodyProject.DataAccessLayer.Repositories;
using FoodyProject.EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodyProject.DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public EfProductDal(FoodyContext context) : base(context)
        {
        }

        public List<Product> GetProductsWithCategories()
        {
            var context = new FoodyContext();
            var values = context.Products.Include(x => x.Category).ToList();
            return values;
   
      }

        public int ProductCount()
        {
            using var context = new FoodyContext();
            return context.Products.Count();
        }

        public int ProductCountByCategoryNameMeyve()
        {
            using var context = new FoodyContext();
            return context.Products.Where(x => x.CategoryID == (context.Categories.Where(y => y.CategoryName == "Meyve").Select(z => z.CategoryID).FirstOrDefault())).Count();
        }

        public int ProductCountByCategoryNameSebze()
        {
            using var context = new FoodyContext();
            return context.Products.Where(x => x.CategoryID == (context.Categories.Where(y => y.CategoryName == "Sebze").Select(z => z.CategoryID).FirstOrDefault())).Count();
        }

        public string ProductNameByMaxPrice()
        {
            using var context= new FoodyContext();
            return context.Products.Where(x => x.Price == (context.Products.Max(y => y.Price))).Select(z => z.ProductName).FirstOrDefault();
        }

        public string ProductNameByMinPrice()
        {
            using var context = new FoodyContext();
            return context.Products.Where(x => x.Price == (context.Products.Min(y => y.Price))).Select(z => z.ProductName).FirstOrDefault();
        }

        public decimal ProductPriceAvg()
        {
            using var context = new FoodyContext();
            return context.Products .Average(x => x.Price);
        }
    }
}
