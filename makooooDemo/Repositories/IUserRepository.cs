using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using makooooDemo.Models;

namespace makooooDemo.Repositories
{
    public interface IUserRepository
    {
        IEnumerable<User> GetUsers();
        User GetUserById(int id);
        void AddUser(User user);
        void DeleteUser(int id);
    }
}
