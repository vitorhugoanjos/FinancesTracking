using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancesTracking.Model
{
    public class Income
    {
        public double Amount { get; private set; }

        public string Description { get; private set; }

        public User User { get; private set; }

        public Income(User user, double amount, string description)
        {
            User = user;
            Amount = amount;
            Description = description;
            User.ReceiveMoney(amount);
        }

        public Income() { }

        public override string ToString()
        {
            return Description + " - " + Amount;  
        }
    }
}
