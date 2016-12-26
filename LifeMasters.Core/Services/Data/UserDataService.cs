using LifeMasters.Core.Contracts.Repositories;
using LifeMasters.Core.Contracts.Services;
using LifeMasters.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeMasters.Core.Services.Data
{
    /// <summary>
    /// Manages user data via the <see cref="IUserRepository"/> which performs the actual data
    /// access. Contain business logic.
    /// </summary>
    public class UserDataService : IUserDataService
    {
        private readonly IUserRepository _userRepository;

        public UserDataService(IUserRepository userRepository)
        {
            if (userRepository == null)
            {
                throw new ArgumentNullException(nameof(userRepository));
            }
            _userRepository = userRepository;
        }
        public async Task<IEnumerable<User>> GetUsers()
        {
            return await _userRepository.GetUsers();
        }

        public async Task<User> GetUser(int userId)
        {
            return await _userRepository.GetUser(userId);
        }
    }
}
