using ChatApplication.Domain.Dtos;

namespace ChatApplication.Domain.Services.Interfaces
{
    public interface IMessageService
    {
        Task<IEnumerable<MessageDto>> GetMessagesByChatIdAsync(Guid chatId);
        Task<MessageDto> SendMessageAsync(CreateMessageDto messageDto);
    }
}
