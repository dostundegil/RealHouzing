using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DtoLayer.MessageDtos;
using RealHouzing.EntityLayer.Concrate;

namespace RealHouzing.ApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly IMessageService _messageService;

        public MessageController(IMessageService messageService)
        {
            _messageService = messageService;
        }
        [HttpGet]
        public IActionResult MessageList()
        {
            var values = _messageService.TGetList();
            return Ok(values);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteMessage(int id)
        {
            var value = _messageService.TGetByID(id);
            _messageService.TDelete(value);
            return Ok();
        }
        [HttpPost]
        public IActionResult SendMessage(SendMessageDto sendMessageDto)
        {
            Message message = new Message()
            {
                Name = sendMessageDto.Name,
                Mail=sendMessageDto.Mail,
                MessageContent=sendMessageDto.MessageContent,
                Date= sendMessageDto.Date,
                Type= sendMessageDto.Type
            };
            _messageService.TInsert(message);
            return Ok();

        }

        [HttpGet("{id}")]
        public IActionResult GetMessage(int id)
        {
            var values = _messageService.TGetByID(id);
            return Ok(values);

        }

        [HttpGet("GetSentMessages")]
        public IActionResult GetSentMessages()
        {
            var values = _messageService.TGetSentMessages();
            return Ok(values);

        }

        [HttpGet("GetRecievedMessages")]
        public IActionResult GetRecievedMessages()
        {
            var values = _messageService.TGetReceivedMessages();
            return Ok(values);

        }

    }
}
