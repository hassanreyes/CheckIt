
using System;
namespace CheckIt.Entities
{
    public interface IUserRepository
    {
        User GetUserByUserName(string userName);
        bool ValidateUser(string id, string password);
        Guid CreateUser(string id, string displayName, string password, string email, int role, string createdBy);
    }
}
