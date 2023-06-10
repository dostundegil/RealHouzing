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
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public List<Product> GetProductsWithCategories()
        {
            var context = new Context();
            var values=context.Products.Include(x=>x.Category).ToList();
            return values;
        }
    }
}
