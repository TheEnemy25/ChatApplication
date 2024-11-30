namespace ChatApplication.Data.Entities
{
    public class User : IEntity
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public ICollection<Message> Messages { get; set; }
        //public ICollection<Chat> Chats { get; set; }
    }
}
