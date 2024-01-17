using Domain.Repository;
using Domain.Response;
using ServiceAbstraction.Abstractions;

namespace Services.Services
{
    internal class UserService : IUserService
    {
        private readonly IRepositoryManager _repositoryManager;

        public UserService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        public async Task<IEnumerable<UserResponseModel>> GetAllAsync()
        {
            var entities = await _repositoryManager.UserRepository.GetAllAsync();
            return entities
                .Select(x => new UserResponseModel
                {
                    Id = x.Id,
                    UserName = x.UserName,
                    Email = x.Email,
                })
                .ToList();
        }
    }
}
