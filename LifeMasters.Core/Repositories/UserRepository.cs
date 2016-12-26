using LifeMasters.Core.Contracts.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LifeMasters.Core.Models;

namespace LifeMasters.Core.Repositories
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        // TODO: get rid of this hardcoded data.
        //
        private static readonly List<User> AllUsers = new List<User>
        {
            new User
            {
                Email = "mickey.mouse@test.com",
                UserId = 1,
                UserName = "mMouse"
            },
            new User
            {
                Email = "donald.duck@test.com",
                UserId = 2,
                UserName = "dDuck"
            },
            new User
            {
                Email = "super.man@test.com",
                UserId = 3,
                UserName = "sMan"
            }
        };

        /// <summary>
        /// Gets all users.
        /// </summary>
        /// <returns>List of <see cref="User"/>.</returns>
        public async Task<IEnumerable<User>> GetUsers()
        {
            return await Task.FromResult(AllUsers);
        }

        /// <summary>
        /// Gets the user specified by <paramref name="userId"/>.
        /// </summary>
        /// <param name="userId">User identifier.</param>
        /// <returns><see cref="User"/> populated with data from the underlying store.</returns>
        public async Task<User> GetUser(int userId)
        {
            return await Task.FromResult(AllUsers.FirstOrDefault(u => u.UserId == userId));
        }
    }
}
