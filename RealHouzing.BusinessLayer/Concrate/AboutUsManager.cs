using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DataAccessLayer.Abstract;
using RealHouzing.EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHouzing.BusinessLayer.Concrate
{
    public class AboutUsManager : IAboutUsService
    {
        private readonly IAboutUsDal _aboutUsDal;

        public AboutUsManager(IAboutUsDal aboutUsDal)
        {
            _aboutUsDal = aboutUsDal;
        }

        public void TDelete(AboutUs t)
        {
            _aboutUsDal.Delete(t);
        }

        public AboutUs TGetByID(int id)
        {
            return _aboutUsDal.GetByID(id);
        }

        public List<AboutUs> TGetList()
        {
            return _aboutUsDal.GetList();
        }

        public void TInsert(AboutUs t)
        {
            _aboutUsDal.Insert(t);
        }

        public void TUpdate(AboutUs t)
        {
            _aboutUsDal.Update(t);
        }
    }
}
