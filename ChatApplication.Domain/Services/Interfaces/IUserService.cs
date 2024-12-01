using ChatApplication.Data.Entities;

namespace ChatApplication.Domain.Services.Interfaces
{
    public interface IUserService
    {
        Task<User> GetUserByIdAsync(Guid userId);
        Task<IEnumerable<User>> GetAllUsersAsync();
    }
}
