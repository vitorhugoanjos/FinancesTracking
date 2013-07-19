using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancesTracking.Model
{
    public class FundsCheck
    {
        private decimal balance;

        public FundsCheck(decimal balance)
        {
            this.balance = balance;
        }

        private void IncreaseCash(decimal cashDeposited)
        {
            balance += cashDeposited;
        }

        private void DecreaseCash(decimal cashWithdrawn)
        {
            balance -= cashWithdrawn;
        }

        public decimal GetBalance()
        {
            return balance;
        }

        public Boolean CanWithdraw(decimal cashTowithdrawal)
        {
            return (cashTowithdrawal <= GetBalance());
        }

        public void Withdraw(decimal cashTowithdrawal)
        {
            if(CanWithdraw(cashTowithdrawal))
            {
                DecreaseCash(cashTowithdrawal);
                Console.WriteLine("Withdrawal complete: Current balance is " + GetBalance());
            }
            else
            {
                Console.WriteLine("Error: You don't have enough money");
                Console.WriteLine("Current balance: " + GetBalance());
            }
        }

        public void MakeDeposit(decimal cashToDeposit)
        {
            IncreaseCash(cashToDeposit);
            Console.WriteLine("Deposit complete: Current balance is " + GetBalance());
        }
    }
}
