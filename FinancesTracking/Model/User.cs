using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancesTracking.Model
{
    public class User
    {

        public string Name { get; private set; }

        public decimal Balance { get; private set; }

        private FundsCheck checker;

        public User(string name, decimal balance)
        {
            Name = name;
            Balance = balance;
            checker = new FundsCheck(balance);
        }

        public void EditName(string name)
        {
            Name = name;
        }


        public void WithdrawCash(decimal amount)
        {
             if(checker.CanWithdraw(amount))
             {
                 checker.Withdraw(amount);
                 Balance = checker.GetBalance();
             }
        }

        public Boolean CanWidthraw(decimal amount)
        {
            return checker.CanWithdraw(amount);
        }

        public void DepositCash(decimal amount)
        {
            checker.MakeDeposit(amount);
            Balance = checker.GetBalance();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}