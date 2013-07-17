using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancesTracking.Model
{
    public class Category
    {
        
        public string Name { get; private set; }

        public Category(string name)
        {
            this.Name = name;
        }

        public Category() { }

        public void EditCategory(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }

    }
}
