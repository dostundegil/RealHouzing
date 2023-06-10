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
    public class PropertyFeaturesManager : IPropertyFeaturesService
    {
        private readonly IPropertyFeaturesDal _propertyFeaturesDal;

        public PropertyFeaturesManager(IPropertyFeaturesDal propertyFeaturesDal)
        {
            _propertyFeaturesDal = propertyFeaturesDal;
        }

        public void TDelete(PropertyFeatures t)
        {
            throw new NotImplementedException();
        }

        public PropertyFeatures TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<PropertyFeatures> TGetList()
        {
            return _propertyFeaturesDal.GetList() ;
        }

        public List<PropertyFeatures> TGetProductsWithFeatures(int id)
        {
            return _propertyFeaturesDal.GetProductsWithFeatures(id);
        }

        public void TInsert(PropertyFeatures t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(PropertyFeatures t)
        {
            throw new NotImplementedException();
        }
    }
}
