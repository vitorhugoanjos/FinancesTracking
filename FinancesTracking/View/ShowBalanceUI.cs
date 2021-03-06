﻿using FinancesTracking.Controller;
using FinancesTracking.Model;
using FinancesTracking.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancesTracking.View
{
    public class ShowBalanceUI : BaseUI
    {
        private ShowBalanceController controller = new ShowBalanceController();

        public void Run()
        {
            User user;

            Header("SHOW USER'S BALANCE");

            user = GetUser();
            decimal balance = controller.GetBalance(user);

            Console.WriteLine("\n\t{0}'s balance is: {1} euros", user.Name, user.Balance);

        }
    }
}
