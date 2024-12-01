using AutoMapper;
using ChatApplication.Data.Entities;
using ChatApplication.Data.Repositories;
using ChatApplication.Domain.Dtos;
using ChatApplication.Domain.Services.Interfaces;

namespace ChatApplication.Domain.Services.Implementations
{
    public class ChatService : IChatService
    {
        private readonly IBaseRepository<Chat> _chatRepository;
        private readonly IMapper _mapper;

        public ChatService(IBaseRepository<Chat> chatRepository, IMapper mapper)
        {
            _chatRepository = chatRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ChatDto>> GetAllChatsAsync()
        {
            var chats = _chatRepository.Query(c => c.Users);
            return _mapper.Map<IEnumerable<ChatDto>>(chats);
        }

        public async Task<ChatDto> GetChatByIdAsync(Guid chatId)
        {
            var chat = await _chatRepository.GetByIdAsync(chatId);
            return _mapper.Map<ChatDto>(chat);
        }

        public async Task<ChatDto> CreateChatAsync(ChatDto chatDto)
        {
            var chat = _mapper.Map<Chat>(chatDto);

            await _chatRepository.AddAsync(chat);
            await _chatRepository.SaveChangesAsync(CancellationToken.None);

            return _mapper.Map<ChatDto>(chat);
        }
    }
}
