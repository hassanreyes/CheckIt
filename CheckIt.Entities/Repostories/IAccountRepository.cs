using System;
using System.Collections.Generic;

namespace CheckIt.Entities
{
    public interface IAccountRepository
    {
        Account GetById(Guid id);

        IEnumerable<Account> GetAccounts();

        Account GetAccount(User user);

        bool SaveAccount(Account Account);

        bool DeleteAccount(Account Account);

        bool SetStatus(Guid id, AccountStatus status);
    }
}
