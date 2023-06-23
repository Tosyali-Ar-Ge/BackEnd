
using FiveS.Repositories.EFCore.Context;
using FiveS.Repositories.Repositories;
using FiveS.Repositories.Repositories.Contracts;

namespace FiveS.Repositories.RepositoryManagement
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _context;
        private readonly Lazy<IUserRepository> _userRepository;

        public RepositoryManager(RepositoryContext context)
        {
            _context = context;
            _userRepository = new Lazy<IUserRepository>(() => new UserRepository(_context));
        }

        public IUserRepository User => _userRepository.Value;            // Lazy Loading

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
