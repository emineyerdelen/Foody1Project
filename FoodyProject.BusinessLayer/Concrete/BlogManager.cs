using FoodyProject.BusinessLayer.Abstract;
using FoodyProject.DataAccessLayer.Abstract;
using FoodyProject.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodyProject.BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        private readonly IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public void TAdd(Blog entity)
        {
           _blogDal.Add(entity);
        }

        public void TDelete(Blog entity)
        {
            _blogDal.Delete(entity);
        }

        public Blog TGetByID(int id)
        {
           return _blogDal.GetByID(id); 
        }

        public List<Blog> TGetListAll()
        {
          return _blogDal.GetListAll();
        }

        public void TUpdate(Blog entity)
        {
        _blogDal.Update(entity);
        }
    }
}
