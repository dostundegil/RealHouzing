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
    public class ProductPropertyFeaturesManager : IProductPropertyFeaturesService
    {
        private readonly IProductPropertyFeaturesDal _productPropertyFeaturesDal;

        public ProductPropertyFeaturesManager(IProductPropertyFeaturesDal productPropertyFeaturesDal)
        {
            _productPropertyFeaturesDal = productPropertyFeaturesDal;
        }

        public void TDelete(ProductPropertyFeatures t)
        {
            throw new NotImplementedException();
        }

        public ProductPropertyFeatures TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<ProductPropertyFeatures> TGetFeaturesByProduct(int id)
        {
            return _productPropertyFeaturesDal.GetFeaturesByProduct(id);
        }

        public List<ProductPropertyFeatures> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TInsert(ProductPropertyFeatures t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(ProductPropertyFeatures t)
        {
            throw new NotImplementedException();
        }
    }
}
