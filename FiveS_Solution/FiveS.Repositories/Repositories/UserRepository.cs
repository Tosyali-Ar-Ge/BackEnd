using FiveS.Repositories.RespositoryBase;
using FiveS.Entities.Entities;
using FiveS.Entities.RequestParameters;
using FiveS.Repositories.EFCore.Context;
using FiveS.Repositories.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveS.Repositories.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(RepositoryContext context) : base(context)
        {
        }

        public void CreateOneUser(User user)
        {
            Create(user);
        }

        public void DeleteOneUser(User user)
        {
            Delete(user);
        }

        public async Task<PagedList<User>> GetAllUsersAsync(UserParameters userParameters, bool trackChanges)
        {
            var users = await FindAll(trackChanges)
                .ToListAsync();

            return PagedList<User>
                .ToPagedList(users,
                userParameters.PageNumber,
                userParameters.PageSize);
        }

        public async Task<User> GetOneUserByIdAsync(int id, bool trackChanges)
        {
            return await FindByCondition(b => b.Id.Equals(id), trackChanges)
                .SingleOrDefaultAsync();
        }

        public async Task<User> GetOneUserByUsernameAsync(string userName, bool trackChanges)
        {
            return await FindByCondition(u => u.UserName.Equals(userName), false)
                .SingleOrDefaultAsync();
        }

        public void UpdateOneUser(User user)
        {
            Update(user);
        }
    }
}
