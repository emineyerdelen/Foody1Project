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
    public class EfBlogDal : GenericRepository<Blog>, IBlogDal
    {
        public EfBlogDal(FoodyContext context) : base(context)
        {
        }
    }
}
