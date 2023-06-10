using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHouzing.DtoLayer.ServiceDtos
{
    public class UpdateServiceDto
    {
        public int ServiceID { get; set; }
        public string ServiceTitle { get; set; }
        public string ServiceDescription { get; set; }
        public string ServiceImage { get; set; }
    }
}
