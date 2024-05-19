using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ5
{
    public class Milk:CoffeeDecorator
    {
        public Milk(Coffee coffee) : base(coffee) { }
        public override String GetDescription()
        {
            return this.coffee.GetDescription() + " and milk";
        }
        public override double GetCost()
        {
            return this.coffee.GetCost() + 0.3;
        }

    }
}
