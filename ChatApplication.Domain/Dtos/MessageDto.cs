namespace ChatApplication.Domain.Dtos
{
    public class MessageDto
    {
        public Guid Id { get; set; }

        public string Content { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
