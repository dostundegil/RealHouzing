using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHouzing.EntityLayer.Concrate
{
    public class ProductPropertyFeatures
    {
        public int ProductPropertyFeaturesID { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }
        public int PropertyFeaturesID { get; set; }
        public PropertyFeatures PropertyFeatures { get; set; }
    }
}
