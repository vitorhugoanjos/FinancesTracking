using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancesTracking.Model;
using FinancesTracking.Persistence;
using FinancesTracking.Controller;

namespace FinancesTracking.View
{
    public class RegisterExpenseUI : BaseUI
    {

        private RegisterExpenseController controller = new RegisterExpenseController();

        public void Run()
        {
            User user;
            string comment;
            decimal amount;
            Category category;
            DateTime date;

            Header("REGISTER EXPENSE");

            user = GetUser();
            comment = GetComment();
            category = GetCategory();
            date = DateTime.Today;

            do
            {
                amount = GetAmount();
            } while (!controller.CanCreateExpense(user, amount));

            controller.CreateExpense(user, comment, amount, category, date);
        }

    }
}
