﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Domain.Account;

namespace BL
{
    public interface IAccountManager
    {
        void addUser(Account account);
        void genereerAlerts();
        List<Alert> getAlleAlerts();
        void UpdateAlert(Alert alert);
        List<Account> GetAccounts();
        Account getAccount(string ID);
        void UpdateUser(Account account);
        void DeleteUser(string accountId);
    }
}
