namespace ChatApplication.Domain.Dtos
{
    public class CreateMessageDto
    {
        public Guid ChatId { get; set; }
        public Guid SenderId { get; set; }
        public string Content { get; set; }
    }
}
