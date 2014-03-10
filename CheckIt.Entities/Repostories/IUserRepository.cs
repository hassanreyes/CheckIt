
using System;
namespace CheckIt.Entities
{
    public interface IUserRepository
    {
        User GetUserByUserName(string userName);
        bool ValidateUser(string id, string password);
        bool SaveUser(User user);
        bool DeleteUser(User user);
    }
}
