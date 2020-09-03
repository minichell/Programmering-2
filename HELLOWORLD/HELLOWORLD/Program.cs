using System;

namespace HELLOWORLD
{
    class Program
    {
            static void Main(string[] args)
            {
                var names = new string[7];

                for (int i = names.Length - 1; i > 1; i--)
                {
                    names[i] = Console.ReadLine();

                }

                foreach (var name in names)
                {
                    Console.WriteLine(name);
                }
            }
        }
    }

