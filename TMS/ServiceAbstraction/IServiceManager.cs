using ServiceAbstraction.Abstractions;

namespace ServiceAbstraction
{
    public interface IServiceManager
    {
        public IUserService UserService { get; }
    }
}
