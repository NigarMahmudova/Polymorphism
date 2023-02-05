using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_task
{
    internal class ProductNotFoundException:Exception
    {
        public ProductNotFoundException(string message):base(message)
        {
            
        }
        
        
    }
}
