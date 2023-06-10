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
    public class EfMessageDal : GenericRepository<Message>, IMessageDal
    {
        public List<Message> GetReceivedMessages()
        {
            var context = new Context();
            return context.Messages.Where(x => x.Type == "Gelen Mesajlar").ToList();
        }

        public List<Message> GetSentMessages()
        {
            var context = new Context();
            return context.Messages.Where(x => x.Type == "Gönderilen Mesajlar").ToList();
        }
    }
}
