using Domain.Repository;
using Infrastructure.Persistance;
using Persistance.Repositories;

namespace Persistance
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly Lazy<IUserRepository> _userRepository;

        public RepositoryManager(RepositoryDbContext dbContext)
        {
            _userRepository = new Lazy<IUserRepository>(() => new UserRepository(dbContext));
        }

        public IUserRepository UserRepository => _userRepository.Value;
    }
}