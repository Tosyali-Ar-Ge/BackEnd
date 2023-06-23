using FiveS.Entities.Dtos;
using FiveS.Entities.Entities;
using FiveS.Entities.RequestParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveS.Services.Contracts
{
    public interface IUserService
    {
        Task<(IEnumerable<User> users, MetaData metadata)> GetAllUsersAsync(UserParameters userParameters, bool trackChanges);
        Task<UserDto> GetOneUserByIdAsync(int id, bool trackChanges);
        Task<UserDto> CreateOneUserAsync(UserDto userDto);
        Task UpdateOneUserAsync(int id, UserDto userDto, bool trackChanges);
        Task DeleteOneUserAsync(int id, bool trackChanges);

        // For (HomePage)
        Task<UserDto> GetOneUserByUsernameAsync(UserDto userDto, bool trackChanges);
    }
}
