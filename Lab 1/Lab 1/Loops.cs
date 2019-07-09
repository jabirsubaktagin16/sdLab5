using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_1
{
    public class Loops
    {
        public void ExploreLoops()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };

            //For Loop
            int sum = 0;
            Console.WriteLine("Inside For Loop: ");
            for (int i = 0; i < numbers.Length; i++)
                sum += numbers[i];
            Console.WriteLine($"Sum is: {sum}");

            //While Loop
            int j = 0;
            sum = 0;
            Console.WriteLine("Inside While Loop: ");
            while(j<numbers.Length)
            {
                sum += numbers[j];
                j++;
            }
            Console.WriteLine($"Sum is: {sum}");

            //Foreach Loop
            sum = 0;
            Console.WriteLine("Inside Foreach Loop: ");
            foreach (var number in numbers)
            {
                sum += number;
            }
            Console.WriteLine($"Sum is: {sum}");
            Console.ReadLine();
        }
    }
}
