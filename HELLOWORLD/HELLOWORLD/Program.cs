using System;

namespace HELLOWORLD
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            string yes;
            
            Console.WriteLine("What's your name? ");
            name = Console.ReadLine();
            Console.WriteLine("What's your age? ");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Are you alive?");
            bool alive = true;
            bool dead = false;
            alive = bool.Parse(Console.ReadLine());
            if (alive)
            {
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Age: " + age);
                Console.WriteLine("Alive: " + alive);
            }
            else
            {
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Age: " + age);
                Console.WriteLine("Alive: " + dead);
            }
          
        }
    }
}
