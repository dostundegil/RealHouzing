namespace RealHouzin.Consume.Models
{
    public class ProductListViewModel
    {
        public int productID { get; set; }
        public string productTitle { get; set; }
        public decimal productPrice { get; set; }
        public string productType { get; set; }
        public string address { get; set; }
        public int bedroomCount { get; set; }
        public int bathCount { get; set; }
        public int square { get; set; }
        public string coverImageUrl { get; set; }
        public object category { get; set; }
        public int categoryID { get; set; }
        public object propertyFeaturess { get; set; }
    }
}
