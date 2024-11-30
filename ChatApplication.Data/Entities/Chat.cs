namespace ChatApplication.Data.Entities
{
    public class Chat : IEntity
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
