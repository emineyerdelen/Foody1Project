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
    public class StaffManager : IStaffService
    {
        private readonly IStaffDal _staffDal;

        public StaffManager(IStaffDal staffDal)
        {
            _staffDal = staffDal;
        }

        public void TAdd(Staff entity)
        {
          _staffDal.Add(entity);
         }

        public void TDelete(Staff entity)
        {
            _staffDal.Delete(entity);
        }

        public Staff TGetByID(int id)
        {
           return _staffDal.GetByID(id);
        }

        public List<Staff> TGetListAll()
        {
           return _staffDal.GetListAll();
        }

        public void TUpdate(Staff entity)
        {
          _staffDal.Update(entity);
        }
    }
}
