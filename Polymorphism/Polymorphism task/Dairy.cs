using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_task
{
    internal class Dairy:Product
    {
        public Dairy(double fatPercent)
        {
            _fatPercent = fatPercent;
        }
        private double _fatPercent;
        public double FatPercent
        {
            get => _fatPercent;
            set => _fatPercent = value;
        }
        public override void ShowProducts()
        {
            Console.WriteLine($"No: {No} - Name: {Name} - Price: {Price} - FatPercent: {_fatPercent}");
        }
    }
}
