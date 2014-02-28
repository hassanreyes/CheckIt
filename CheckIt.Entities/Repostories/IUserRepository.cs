
using System;
namespace CheckIt.Entities
{
    public interface IUserRepository
    {
        User GetUserByDisplayName(string displayName);
        bool ValidateUser(string id, string password);
        Guid CreateUser(string id, string displayName, string password, string email, int role, string createdBy);
    }
}
