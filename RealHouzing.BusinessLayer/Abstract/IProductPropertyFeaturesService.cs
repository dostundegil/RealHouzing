using RealHouzing.EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHouzing.BusinessLayer.Abstract
{
    public interface IProductPropertyFeaturesService:IGenericService<ProductPropertyFeatures>
    {
        List<ProductPropertyFeatures> TGetFeaturesByProduct(int id);
    }
}
