using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ5
{
    public abstract class CoffeeDecorator:Coffee
    {
        protected Coffee coffee;

        public CoffeeDecorator(Coffee coffee)
        {
            this.coffee = coffee;
        }

        public virtual double GetCost()
        {
            return coffee.GetCost();
        }

        public virtual string GetDescription()
        {
            return coffee.GetDescription(); 
        }
    }
}
