using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        private const int SHOW_INCOMINGS = 6;

        private const int SHOW_SAVINGS = 7;


        private FinancesTrackingUI() { }

        public static FinancesTrackingUI GetUI()
        {
            return menu == null ? (menu = new FinancesTrackingUI()) : menu;
        }

        private void ShowMenu()
        {
            Console.WriteLine("1. Register expense");
            Console.WriteLine("2. Register income");
            Console.WriteLine("3. Register daving");

            Console.WriteLine("4. Show balance");
            Console.WriteLine("5. Show expenses");
            Console.WriteLine("6. Show incomes");
            Console.WriteLine("7. Show savings");

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
                            
                            break;

                        case REGISTER_SAVING:
                            //TODO some code
                            break;

                        case SHOW_BALANCE:
                            //TODO some code
                            break;

                        case SHOW_EXPENSES:
                            //TODO some code
                            break;

                        case SHOW_INCOMINGS:
                            //TODO some code
                            break;

                        case SHOW_SAVINGS:
                            //TODO some code
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
