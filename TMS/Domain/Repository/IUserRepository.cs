using Domain.Entities;

namespace Domain.Repository
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAllAsync();
    }
}
