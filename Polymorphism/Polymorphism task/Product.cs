using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_task
{
    internal class Product 
    {
        private static int _totalCount;
        public Product()
        {
            _totalCount++;
            _no = _totalCount;
        }
        private int _no;
        public int No => _no;
        public string Name;
        private double _price;
        public double Price
        {
            get => _price;
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
            }
        }
        public virtual void ShowProducts()
        {
            Console.WriteLine($"No: {No} - Name: {Name} - Price: {Price}");
        }
    }
}
