using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_task
{
    internal interface IStore
    {
        public Product[] Products { get; set; }
        public void AddProduct(Product product);
        public Product[] RemoveProduct(int no);
        public bool HasProductByNo(int no);
        public Product GetProductByNo(int no);
        
    }
}
