using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_task
{
    internal class Drink:Product
    {
        public Drink(double alcoholPercent)
        {
            _alcoholPercent = alcoholPercent;
        }
        private double _alcoholPercent;
        public double AlcoholPercent
        {
            get => _alcoholPercent;
            set
            {
                if (value >= 0 && value <= 100)
                {
                    _alcoholPercent = value;
                }
            }
        }
        public override void ShowProducts()
        {
            Console.WriteLine($"No: {No} - Name: {Name} - Price: {Price} - AlcoholPercent: {_alcoholPercent}");
        }

    }
}
