using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHouzing.DtoLayer.ContactUsDtos
{
    public class UpdateContactUsDto
    {
        public int ContactUsID { get; set; }
        public string Address { get; set; }
        public string Telephone1 { get; set; }
        public string Telephone2 { get; set; }
        public string Website { get; set; }
        public string Mail { get; set; }
        public string MapUrl { get; set; }
    }
}
