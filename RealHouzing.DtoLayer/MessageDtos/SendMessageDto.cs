using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHouzing.DtoLayer.MessageDtos
{
    public class SendMessageDto
    {
        public int MessageID { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public DateTime Date { get; set; }
        public string? Type { get; set; }
        public string MessageContent { get; set; }
    }
}
