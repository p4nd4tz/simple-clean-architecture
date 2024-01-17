﻿using Domain.Repository;
using ServiceAbstraction;
using ServiceAbstraction.Abstractions;
using Services.Services;

namespace Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<IUserService> _lazyUserService;

        public ServiceManager(IRepositoryManager repositoryManager)
        {
            _lazyUserService = new Lazy<IUserService>(() => new UserService(repositoryManager));
        }

        public IUserService UserService => _lazyUserService.Value;
    }
}
