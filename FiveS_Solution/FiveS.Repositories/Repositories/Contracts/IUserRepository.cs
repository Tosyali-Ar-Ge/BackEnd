using FiveS.Repositories.RespositoryBase;
using FiveS.Entities.Entities;
using FiveS.Entities.RequestParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveS.Repositories.Repositories.Contracts
{
    public interface IUserRepository : IRepositoryBase<User>
    {
        Task<PagedList<User>> GetAllUsersAsync(UserParameters userParameters, bool trackChanges);
        Task<User> GetOneUserByIdAsync(int id, bool trackChanges);
        Task<User> GetOneUserByUsernameAsync(string userName, bool trackChanges);
        void CreateOneUser(User user);
        void UpdateOneUser(User user);
        void DeleteOneUser(User user);
    }
}
