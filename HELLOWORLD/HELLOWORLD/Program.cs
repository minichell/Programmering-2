using System;

namespace HELLOWORLD
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            string aliveOrNot;
           
            
            Console.WriteLine("What's your name? ");
            name = Console.ReadLine();

            Console.WriteLine("How old are you? ");
            age = int.Parse(Console.ReadLine());

            for ( int i = 0; i < 1; i++)
            {
                if(age == 18)
                {
                    Console.WriteLine("cool");
                }
            }

            Console.WriteLine("Are you alive?");
            bool alive = true;
            bool dead = false;
            aliveOrNot = Console.ReadLine();

            if(aliveOrNot == "false")
            {
                Console.WriteLine("cool");
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Age: " + age);
                Console.WriteLine("Alive: " + dead);
                alive = false;
            }

            while (alive)
            {

                Console.WriteLine("U wanna se the result?? ");
                Console.WriteLine(" 1 = yes");
                Console.WriteLine(" 2 = no");
                int choosingResult = 1;
                choosingResult = int.Parse(Console.ReadLine());
                switch (choosingResult)
                {
                    case 1:
                        Console.WriteLine("Name: " + name);
                        Console.WriteLine("Age: " + age);
                        Console.WriteLine("Alive: " + alive);
       
                       alive = false;
                       break;

                    case 2:

                    Console.WriteLine("okayyy cyaaa");
                        alive = false;
                        break;
                } 
            }

        }
    }
}
