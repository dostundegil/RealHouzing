using Microsoft.EntityFrameworkCore;
using RealHouzing.DataAccessLayer.Abstract;
using RealHouzing.DataAccessLayer.Concrate;
using RealHouzing.DataAccessLayer.Repository;
using RealHouzing.EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHouzing.DataAccessLayer.EntityFramework
{
    public class EfProductPropertyFeaturesDal : GenericRepository<ProductPropertyFeatures>, IProductPropertyFeaturesDal
    {
        public List<ProductPropertyFeatures> GetFeaturesByProduct(int id)
        {
            using var context = new Context();
            var value = context.ProductPropertyFeaturess.Where(y => y.ProductID == id).Include(x => x.PropertyFeatures).Include(y=>y.Product).ToList();
            return value;
        }
    }
}
