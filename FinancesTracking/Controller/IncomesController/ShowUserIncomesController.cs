﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancesTracking.Model;
using FinancesTracking.Persistence;

namespace FinancesTracking.Controller
{
    public class ShowUserIncomesController
    {
        public List<Income> GetUserIncomes(User user)
        {
            return Factory.GetFactory().GetIncomesRepository().GetUserIncomes(user);
        }
    }
}
