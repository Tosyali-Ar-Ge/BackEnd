using AutoMapper;
using FiveS.Repositories.RepositoryManagement;
using FiveS.Entities.Dtos;
using FiveS.Entities.Entities;
using FiveS.Entities.RequestParameters;
using FiveS.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveS.Services
{
    public class UserManager : IUserService
    {

        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public UserManager(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<UserDto> CreateOneUserAsync(UserDto userDto)
        {
            var user = _mapper.Map<User>(userDto);
            _repositoryManager.User.CreateOneUser(user);
            _repositoryManager.SaveAsync();

            return userDto;
        }

        public Task DeleteOneUserAsync(int id, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<(IEnumerable<User> users, MetaData metadata)> GetAllUsersAsync(UserParameters userParameters, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<UserDto> GetOneUserByIdAsync(int id, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public async Task<UserDto> GetOneUserByUsernameAsync(UserDto userDto, bool trackChanges)
        {
            // userName'e ait kullanıcı var mı?
            var user = await _repositoryManager.User.GetOneUserByUsernameAsync(userDto.UserName, trackChanges);

            return _mapper.Map<UserDto>(user);
        }

        public Task UpdateOneUserAsync(int id, UserDto userDto, bool trackChanges)
        {
            throw new NotImplementedException();
        }
    }
}
