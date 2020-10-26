using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace OOP___Lab
{
    class Program
    {

        public Custom customer = new Custom();
        public Product products = new Product();
        public List<string> orderList = new List<string>();

        static void Main(string[] args)
        {
            Program control = new Program();
            control.theCustom();
            control.order();
        }

        public void order()
        {
            while (true)
            {
                Console.WriteLine("Choose your products pls:");
                Console.WriteLine("1. apple" + "\n" +
                                  "2. orange   " + "\n" +
                                  "3. lemon " + "\n" +
                                  "4. Done!");
                int custom = Convert.ToInt32(Console.ReadLine());

                switch (custom)
                {
                    case 1:
                       
         
                        orderList.Add("apple");
                        continue;
                    case 2:
                   
                        orderList.Add("orange");
                        continue;
                    case 3:

                        orderList.Add("lemon");
                        continue;
                    case 4:

                        Console.WriteLine("Your list:");
                        orderList.ToArray();
                        foreach(var productList in orderList)
                        {
                            Console.WriteLine(productList);
                        }
                        break;
                }
                break;
            }
        }
        public void theCustom()
        {
            Console.WriteLine("Whats your name?");
            customer.name = Console.ReadLine();
        }
    }
}

            

      
    

