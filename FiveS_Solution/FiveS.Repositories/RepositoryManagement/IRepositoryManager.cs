using FiveS.Entities.Entities;
using FiveS.Repositories.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveS.Repositories.RepositoryManagement
{
    public interface IRepositoryManager
    {
        IUserRepository User { get; }
        Task SaveAsync();
    }
}
