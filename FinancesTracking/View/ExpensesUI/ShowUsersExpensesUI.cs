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
    public class ShowUsersExpensesUI : BaseUI
    {
        private ShowUsersExpensesController controller = new ShowUsersExpensesController();

        public void Run()
        {
            User user;
            Header("SHOW USER EXPENSES");
            user = GetUser();

            PrintList(controller.GetUserExpenses(user), "This user has no expense");

        }
    }
}
