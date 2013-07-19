using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancesTracking.View.IncomesUI;

namespace FinancesTracking.View
{
    public class FinancesTrackingUI
    {
        private static FinancesTrackingUI menu = null;

        private const int EXIT = 0;

        private const int REGISTER_EXPENSE = 1;

        private const int REGISTER_INCOME = 2;

        private const int REGISTER_SAVING = 3;

        private const int SHOW_BALANCE = 4;

        private const int SHOW_EXPENSES = 5;

        private const int SHOW_USER_EXPENSES = 6;

        private const int SHOW_MONTH_EXPENSES = 7;

        private const int SHOW_CATEGORY_EXPENSES = 8;

        private const int SHOW_CATEGORY_USER_EXPENSES = 9;

        private const int SHOW_CATEGORY_MONTH_EXPENSES = 10;

        private const int SHOW_INCOMINGS = 11;

        private const int SHOW_USER_INCOMINGS = 12;

        private const int SHOW_MONTH_INCOMINGS = 13;

        private const int SHOW_SAVINGS = 14;

        private const int SHOW_USERS_SAVINGS = 15;


        private FinancesTrackingUI() { }

        public static FinancesTrackingUI GetUI()
        {
            return menu == null ? (menu = new FinancesTrackingUI()) : menu;
        }

        private void ShowMenu()
        {
            Console.WriteLine("1. Register expense");
            Console.WriteLine("2. Register income");
            Console.WriteLine("3. Register saving");

            Console.WriteLine("4. Show balance");
            Console.WriteLine("5. Show all expenses");
            Console.WriteLine("6. Show user's expenses");
            Console.WriteLine("7. Show expenses by month");
            Console.WriteLine("8. Show expenses by category");
            Console.WriteLine("9. Show expenses by category and user");
            Console.WriteLine("10. Show expenses by category and month");

            Console.WriteLine("11. Show incomes");
            Console.WriteLine("12. Show user's incomes");
            Console.WriteLine("13. Show all savings");
            Console.WriteLine("114. Show user's savings");

            Console.WriteLine("0. Exit");

            Console.WriteLine("\nChoose an option:");
        }

        public void Run()
        {
            int op;

            do
            {
                ShowMenu();

                if (int.TryParse(Console.ReadLine(), out op))
                {
                    switch (op)
                    {
                        case REGISTER_EXPENSE:
                            RegisterExpenseUI registerExpense = new RegisterExpenseUI();
                            registerExpense.Run();
                            break;

                        case REGISTER_INCOME:
                            RegisterIncomeUI registerIncome = new RegisterIncomeUI();
                            registerIncome.Run();
                            break;

                        case REGISTER_SAVING:
                            RegisterSavingUI registerSaving = new RegisterSavingUI();
                            registerSaving.Run();
                            break;

                        case SHOW_BALANCE:
                            ShowBalanceUI showBalance = new ShowBalanceUI();
                            showBalance.Run();
                            break;

                        case SHOW_EXPENSES:
                            ShowExpensesUI showExpenses = new ShowExpensesUI();
                            showExpenses.Run();
                            break;

                        case SHOW_USER_EXPENSES:
                            ShowUsersExpensesUI showUserExpenses = new ShowUsersExpensesUI();
                            showUserExpenses.Run();
                            break;

                        case SHOW_MONTH_EXPENSES:
                            ShowMonthExpensesUI showMonthExpenses = new ShowMonthExpensesUI();
                            showMonthExpenses.Run();
                            break;

                        case SHOW_CATEGORY_EXPENSES:
                            ShowCategoryExpensesUI showCategoryExpenses = new ShowCategoryExpensesUI();
                            showCategoryExpenses.Run();
                            break;

                        case SHOW_CATEGORY_USER_EXPENSES:
                            ShowCategoryUserExpensesUI showCategoryUserExpenses = new ShowCategoryUserExpensesUI();
                            showCategoryUserExpenses.Run();
                            break;

                        case SHOW_CATEGORY_MONTH_EXPENSES:
                            ShowCategoryMonthExpensesUI showCategoryMonthExpenses = new ShowCategoryMonthExpensesUI();
                            showCategoryMonthExpenses.Run();
                            break;

                        case SHOW_INCOMINGS:
                            ShowAllIncomesUI showAllIncomes = new ShowAllIncomesUI();
                            showAllIncomes.Run();
                            break;

                        case SHOW_USER_INCOMINGS:
                            ShowUserIncomesUI showUserIncomes = new ShowUserIncomesUI();
                            showUserIncomes.Run();
                            break;

                        case SHOW_SAVINGS:
                            //TODO some code
                            break;

                        case SHOW_USERS_SAVINGS:
                            ShowUserSavingsUI showUserSavings = new ShowUserSavingsUI();
                            showUserSavings.Run();
                            break;

                        case EXIT:
                            Console.WriteLine("Exiting...");
                            break;

                        default:
                            Console.WriteLine("Not a valid option!");
                            break;
                    }
                }
                else
                {
                    Run();
                }
            } while (op != 0);
        }
    }
}
