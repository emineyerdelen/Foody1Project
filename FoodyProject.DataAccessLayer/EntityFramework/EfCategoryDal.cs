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
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        public EfCategoryDal(FoodyContext context) : base(context)
        {
        }

        public int ActiveCategoryCount()
        {
            using var context = new FoodyContext();
            return context.Categories.Where(x => x.CategoryStatus == true).Count();
        }

        public int CategoryCount()
        {
           using var context=new FoodyContext(); 
            return context.Categories.Count();
        }

        public int PassiveCategoryCount()
        {
            using var context = new FoodyContext();
            return context.Categories.Where(x=>x.CategoryStatus == false).Count();
        }
    }
}
