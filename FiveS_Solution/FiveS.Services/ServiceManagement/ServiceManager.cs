using AutoMapper;
using FiveS.Repositories.RepositoryManagement;
using FiveS.Services.Contracts;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveS.Services.ServiceManagement
{
    public class ServiceManager : IServiceManager
    {
        // Bütün servisleri burada topluyoruz ve onlara ihtiyacımız olduğunda LazyLoading kullanarak onları kullanabiliyoruz
        private readonly Lazy<IUserService> _userService;

        public ServiceManager(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _userService = new Lazy<IUserService>(() => new UserManager(repositoryManager, mapper));
        }
        public IUserService User => _userService.Value;
    }
}
