using System;

namespace HELLOWORLD
{
    class Program
    {
            static void Main(string[] args)
            {
                var words = new string[5];

                for (int i = words.Length - 1; i > 1; i--)
                {
                    words[i] = Console.ReadLine();

                }

                foreach (var word in words)
                {
                    Console.WriteLine(word);
                }
            }
        }
    }

