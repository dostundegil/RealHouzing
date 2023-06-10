

namespace RealHouzin.Consume.Models
{
    public class ProductDetailViewModel
    {
        public int productPropertyFeaturesID { get; set; }
        public int productID { get; set; }
        public ProductListViewModel product { get; set; }
        public int propertyFeaturesID { get; set; }
        public Propertyfeatures propertyFeatures { get; set; }
    }
}
