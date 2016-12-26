using LifeMasters.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeMasters.Core.Contracts.Services
{
    public interface IUserDataService
    {
        Task<IEnumerable<User>> GetUsers();
        Task<User> GetUser(int userId);
    }
}
