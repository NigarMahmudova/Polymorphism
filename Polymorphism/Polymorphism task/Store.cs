using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_task
{
    internal class Store:IStore
    {

        private int _dairyProductTotalCount;

        public Store(int dairyProductCountLimit, double alcoholPercentLimit)
        {
            _dairyProductCountLimit = dairyProductCountLimit;
            _alcoholPercentLimit = alcoholPercentLimit;
        }

        private Product[] _products = new Product[0];
        public Product[] Products
        {
            get => _products;

            set
            {
                _products = value;
            }

        }
        private int _dairyProductCountLimit;
        public int DairyProductCountLimit => _dairyProductCountLimit;

        private double _alcoholPercentLimit;
        public double AlcoholPercentLimit
        {
            get => _alcoholPercentLimit;
            set => _alcoholPercentLimit = value;
        }
        
        public void AddProduct(Product product)
        {

            if (product is Dairy)
            {
                _dairyProductTotalCount++;
                if (_dairyProductTotalCount <= _dairyProductCountLimit)
                {
                    Array.Resize(ref _products, _products.Length + 1);
                    _products[_products.Length - 1] = product;
                }
                else if (_dairyProductTotalCount > _dairyProductCountLimit)
                {
                    throw new Exception("DairyProductCountLimit asilir.");
                }

            }
            else if (product is Drink)
            {
                Drink drink = (Drink)product;
                if (drink.AlcoholPercent <= _alcoholPercentLimit)
                {
                    Array.Resize(ref _products, _products.Length + 1);
                    _products[_products.Length - 1] = product;
                }
                else if (drink.AlcoholPercent > _alcoholPercentLimit)
                {
                    throw new Exception("AlcoholPercentLimit asilir.");
                }

            }

        }

        public Product GetProductByNo(int no)
        {
            foreach (var item in _products)
            {
                if (item.No == no)
                {
                    return item;
                }
            }
            throw new ProductNotFoundException($"{no} nomreli product yoxdur.");
        }

        public bool HasProductByNo(int no)
        {
            foreach (var item in _products)
            {
                if (item.No == no)
                {
                    return true;
                }
            }
            return false;
        }

        public Product[] RemoveProduct(int no)
        {
            Product[] newProducts = new Product[0];
           
            for (int i = 0; i < _products.Length; i++)
            {
                if (_products[i].No != no)
                {
                    Array.Resize(ref newProducts,newProducts.Length + 1);
                    newProducts[newProducts.Length - 1] = _products[i];
                }
            }
            _products = newProducts;
            return _products;
        }

        public Dairy[] GetDairyProducts(Product[] products)
        {
            Dairy[] dairyes = new Dairy[0];
            foreach (var item in _products)
            {
                if (item is Dairy)
                {
                    Dairy dairy = (Dairy)item;
                    Array.Resize(ref dairyes, dairyes.Length + 1);
                    dairyes[dairyes.Length - 1] = dairy;
                }
            }
            return dairyes;
        }
        public Drink[] GetDrinkProducts(Product[] products)
        {
            Drink[] drinks = new Drink[0];
            foreach (var item in _products)
            {
                if (item is Drink)
                {
                    Drink drink = (Drink)item;
                    Array.Resize(ref drinks, drinks.Length + 1);
                    drinks[drinks.Length - 1] = drink;
                }
            }
            return drinks;
        }
    }
}
