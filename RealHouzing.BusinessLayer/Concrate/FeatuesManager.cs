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
    public class FeatuesManager : IFeatuesService
    {
        private readonly IFeatuesDal _featuesDal;

        public FeatuesManager(IFeatuesDal featuesDal)
        {
            _featuesDal = featuesDal;
        }

        public void TDelete(Featues t)
        {
            throw new NotImplementedException();
        }

        public Featues TGetByID(int id)
        {
            return _featuesDal.GetByID(id);
        }

        public List<Featues> TGetList()
        {
            return _featuesDal.GetList();
        }

        public void TInsert(Featues t)
        {
            _featuesDal.Insert(t);
        }

        public void TUpdate(Featues t)
        {
            _featuesDal.Update(t);
        }
    }
}
