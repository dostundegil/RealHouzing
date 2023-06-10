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
    public class EfPropertyFeaturesDal : GenericRepository<PropertyFeatures>, IPropertyFeaturesDal
    {
        public List<PropertyFeatures> GetProductsWithFeatures(int id)
        {
            var context = new Context();
            var values = context.PropertyFeatures.Include(x => x.Products).ToList();

            return values;
        }
    }
}
