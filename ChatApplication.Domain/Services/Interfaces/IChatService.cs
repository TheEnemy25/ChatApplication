using ChatApplication.Domain.Dtos;

namespace ChatApplication.Domain.Services.Interfaces
{
    public interface IChatService
    {
        Task<IEnumerable<ChatDto>> GetAllChatsAsync();
        Task<ChatDto> GetChatByIdAsync(Guid chatId);
        Task<ChatDto> CreateChatAsync(ChatDto chatDto);
    }
}
