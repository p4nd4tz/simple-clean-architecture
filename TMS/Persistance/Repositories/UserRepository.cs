using Domain.Entities;
using Domain.Repository;
using Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;

namespace Persistance.Repositories
{
    internal sealed class UserRepository : IUserRepository
    {
        private readonly RepositoryDbContext _dbContext;

        public UserRepository(RepositoryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            return await _dbContext.Users.ToListAsync();
        }
    }
}
