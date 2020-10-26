using System;
using System.Collections.Generic;
using System.Text;

namespace OOP___Lab
{
    class Product
    {
      
        public void product()
        {
            Console.WriteLine("products");
        }
    }

    class apple: Product
        {
        public void product()
         {
        Console.WriteLine("apple");
       }
    }

    class orange: Product
        {
        public void product()
        {
            Console.WriteLine("orange");
        }
    }

    class lemon: Product
        {
        public void product()
            {
            Console.WriteLine("lemon");
        }
    }
}
