using RealHouzing.DataAccessLayer.Abstract;
using RealHouzing.DataAccessLayer.Repository;
using RealHouzing.EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHouzing.DataAccessLayer.EntityFramework
{
    public class EfFeatuesDal:GenericRepository<Featues>,IFeatuesDal
    {
    }
}
