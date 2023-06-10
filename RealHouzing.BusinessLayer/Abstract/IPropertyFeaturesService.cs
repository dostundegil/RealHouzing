using RealHouzing.EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHouzing.BusinessLayer.Abstract
{
    public interface IPropertyFeaturesService:IGenericService<PropertyFeatures>
    {
        List<PropertyFeatures> TGetProductsWithFeatures(int id);
    }
}
