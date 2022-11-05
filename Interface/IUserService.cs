using Online_Store.DTO;
using Online_Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Store.Interface
{
    public interface IUserService
    {
        Task<List<User>> GetUsers();
        Task<User> GetSingleUserById(Guid id);
        Task AddUser(CreateUserDTO user);
        Task UpdateUserById(Guid id, User user);
        Task DeleteSingleUserById(Guid id);
    }
}
