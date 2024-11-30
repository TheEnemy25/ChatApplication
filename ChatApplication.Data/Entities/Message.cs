namespace ChatApplication.Data.Entities
{
    public class Message : IEntity
    {
        public Guid Id { get; set; }

        public Guid SenderId { get; set; }
        public Guid ChatId { get; set; }

        public string Content { get; set; }
        public DateTime Timestamp { get; set; }
        public string Sentiment { get; set; }
        public bool IsRead { get; set; } = false;

        public User Sender { get; set; }
        public Chat Chat { get; set; }
    }
}
