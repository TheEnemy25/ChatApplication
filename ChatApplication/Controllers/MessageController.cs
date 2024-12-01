using ChatApplication.Domain.Dtos;
using ChatApplication.Domain.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ChatApplication.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MessageController : ControllerBase
    {
        private readonly IMessageService _messageService;

        public MessageController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        [HttpGet("{chatId}/messages")]
        public async Task<IActionResult> GetMessages(Guid chatId)
        {
            var messages = await _messageService.GetMessagesByChatIdAsync(chatId);
            return Ok(messages);
        }

        [HttpPost("{chatId}/messages")]
        public async Task<IActionResult> SendMessage(Guid chatId, [FromBody] CreateMessageDto messageDto)
        {
            messageDto.ChatId = chatId;
            var message = await _messageService.SendMessageAsync(messageDto);
            return CreatedAtAction(nameof(GetMessages), new { chatId }, message);
        }
    }
}
