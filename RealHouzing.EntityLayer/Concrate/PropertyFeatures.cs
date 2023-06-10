using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHouzing.EntityLayer.Concrate
{
    public class PropertyFeatures
    {
        public int PropertyFeaturesID { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public bool Status { get; set; }
        public List<Product> Products { get; set; }
    }
}
