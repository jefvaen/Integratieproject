﻿using Domain.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface IPlatformManager
    {
        StringBuilder ConvertToCSV(List<Account> accounts);
    }
}
