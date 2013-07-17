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

        public double Balance { get; private set; }

        public User(string name, double balance)
        {
            Name = name;
            Balance = balance;
        }

        public void EditName(string name)
        {
            Name = name;
        }


        public void UseMoney(double amount)
        {
            if (Balance - amount < 0)
                throw new System.ArgumentOutOfRangeException("amount", "The amount can't be greater than the user's balance");
            else
                Balance -= amount;
        }

        public void ReceiveMoney(double amount)
        {
            Balance += amount;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}