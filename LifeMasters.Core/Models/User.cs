using LifeMasters.Core.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeMasters.Core.Models
{
    /// <summary>
    /// Represents a user.
    /// </summary>
    public class User : BaseModel
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
    }
}
