using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DataAccessLayer.Abstract;
using RealHouzing.EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHouzing.BusinessLayer.Concrate
{
    public class AgentManager : IAgentService
    {
        private readonly IAgentDal _agentDal;

        public AgentManager(IAgentDal agentDal)
        {
            _agentDal = agentDal;
        }

        public void TDelete(Agent t)
        {
            _agentDal.Delete(t);
        }

        public Agent TGetByID(int id)
        {
            return _agentDal.GetByID(id);
        }

        public List<Agent> TGetList()
        {
            return _agentDal.GetList();
        }

        public void TInsert(Agent t)
        {
            _agentDal.Insert(t);
        }

        public void TUpdate(Agent t)
        {
            _agentDal.Update(t);
        }
    }
}
