using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DtoLayer.AgentDtos;
using RealHouzing.EntityLayer.Concrate;

namespace RealHouzing.ApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgentController : ControllerBase
    {
        private readonly IAgentService _agentService;

        public AgentController(IAgentService agentService)
        {
            _agentService = agentService;
        }

        [HttpGet]
        public IActionResult AgentList()
        {
            var values = _agentService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddAgent(ResultAgentDto dto)
        {
            Agent agent = new Agent()
            {
                AgentName = dto.AgentName,
                AgentTitle = dto.AgentTitle,
                AgentPhone = dto.AgentPhone,
                AgentMail = dto.AgentMail,
                AgentImage = dto.AgentImage,
                AgentSocial1 = dto.AgentSocial1,
                AgentSocial2 = dto.AgentSocial2,
                AgentSocial3 = dto.AgentSocial3,
                AgentSocial4 = dto.AgentSocial4,
            };
            _agentService.TInsert(agent);
            return Ok();

        }
        [HttpPut]
        public IActionResult UpdateAgent(UpdateAgentDto dto)
        {
            Agent agent = new Agent()
            {
                AgentID = dto.AgentID,
                AgentName = dto.AgentName,
                AgentTitle = dto.AgentTitle,
                AgentPhone = dto.AgentPhone,
                AgentMail = dto.AgentMail,
                AgentImage = dto.AgentImage,
                AgentSocial1 = dto.AgentSocial1,
                AgentSocial2 = dto.AgentSocial2,
                AgentSocial3 = dto.AgentSocial3,
                AgentSocial4 = dto.AgentSocial4,
            };
            _agentService.TUpdate(agent);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetAgent(int id)
        {
            var values = _agentService.TGetByID(id);
            return Ok(values);

        }
        [HttpDelete("{id}")]
        public IActionResult DeleteAgent(int id)
        {
            var value = _agentService.TGetByID(id);
            _agentService.TDelete(value);
            return Ok();
        }
    }
}
