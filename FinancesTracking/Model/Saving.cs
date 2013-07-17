using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancesTracking.Model
{
    public class Saving
    {

        public string GoalName { get; private set;}

        public string Description { get; private set; }

        public double GoalAmount { get; private set; }

        public double InitialAmount { get; private set; }

        public double CurrentAmount { get; private set; }

        public bool HasReachedGoal { get; private set; }

        public User User { get; private set; }


        public Saving(User user, string goalName, string description, double goalAmount, double initialAmount)
        {
            User = user;
            GoalName = goalName;
            Description = description;
            GoalAmount = goalAmount;
            InitialAmount = initialAmount;
            User.UseMoney(initialAmount);
        }


        public Saving() { }

        public int putMoney(double amount)
        {
            if((CurrentAmount + amount) > GoalAmount)
                return -1;

            if ((CurrentAmount + amount) == GoalAmount)
            {
                CurrentAmount += amount;
                HasReachedGoal = true;
                return 1;
            }

            CurrentAmount += amount;
            return 0;
        }

        public int takeMoney(double amount)
        {
            if ((CurrentAmount - amount) < 0)
                return -1;

            CurrentAmount -= amount;
            return 0;
        }

        public override string ToString()
        {
            return GoalName + " - Goal: " + GoalAmount + "€ Currently have: " + CurrentAmount + "€.";
        }
    }
}
