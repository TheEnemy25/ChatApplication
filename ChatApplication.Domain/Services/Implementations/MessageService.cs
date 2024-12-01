using AutoMapper;
using ChatApplication.Data.Entities;
using ChatApplication.Data.Repositories;
using ChatApplication.Domain.Dtos;
using ChatApplication.Domain.Services.Interfaces;

namespace ChatApplication.Domain.Services.Implementations
{
    public class MessageService : IMessageService
    {
        private readonly IBaseRepository<Message> _messageRepository;
        private readonly IMapper _mapper;

        public MessageService(IBaseRepository<Message> messageRepository, IMapper mapper)
        {
            _messageRepository = messageRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<MessageDto>> GetMessagesByChatIdAsync(Guid chatId)
        {
            var messages = _messageRepository.Query(m => m.Sender, m => m.Chat)
                .Where(m => m.ChatId == chatId);

            return _mapper.Map<IEnumerable<MessageDto>>(messages);
        }

        public async Task<MessageDto> SendMessageAsync(CreateMessageDto messageDto)
        {
            var message = _mapper.Map<Message>(messageDto);
            message.Timestamp = DateTime.UtcNow;

            await _messageRepository.AddAsync(message);
            await _messageRepository.SaveChangesAsync(CancellationToken.None);

            return _mapper.Map<MessageDto>(message);
        }
    }
}
