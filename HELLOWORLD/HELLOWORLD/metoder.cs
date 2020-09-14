using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HELLOWORLD
{
    class metoder
    {
        static void Main(string[] args)
        {

            int numberOfResult = Sum();
            Console.WriteLine("The result is:" + numberOfResult);

            string[] listOnBackward = backwardsWord();


            var (biggestNumber, sortestNumber) = orderNum();
            Console.WriteLine("The biggest number:" + biggestNumber);
            Console.WriteLine("The sortest number:" + sortestNumber);
        }

        private static int Sum()
        {
            Console.WriteLine("Pls write numbers");
            int sum = 0;
            var numbers = new int[6];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                sum = sum + numbers[i];
            }

            return sum;
        }

        private static string[] backwardsWord()
        {
            Console.WriteLine("Pls write some words");
            var words = new string[6];
            for (int i = words.Length - 1; i > 1; i--)
            {
                words[i] = Console.ReadLine();
            }

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
            return words;
        }

        private static (int biggestNum, int sortNum) orderNum()
        {
            int biggestNum = 0;
            int sortNum = 0;
            Console.WriteLine("Pls write some numbers");
            var numbers = new int[5];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            biggestNum = numbers.Max();
            sortNum = numbers.Min();

            return (biggestNum, sortNum);
        }
    }
}

