using FinancesTracking.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancesTracking.Model;
using FinancesTracking.Persistence;


namespace FinancesTracking.View
{
    public class RegisterIncomeUI:BaseUI
    {
        private RegisterIncomeController controller = new RegisterIncomeController();

        public void Run()
        {
            User user;
            string comment;
            decimal amount;

            Header("REGISTER INCOME");

            user = GetUser();
            comment = GetComment();
            amount = GetAmount();

            controller.CreateIncome(user, amount, comment);

        }
    }
}
