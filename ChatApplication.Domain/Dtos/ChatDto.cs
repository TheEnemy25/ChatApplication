namespace ChatApplication.Domain.Dtos
{
    public class ChatDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        public IEnumerable<UserDto> Users { get; set; }
    }
}
