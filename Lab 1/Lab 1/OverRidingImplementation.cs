using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_1
{
    public class OverRidingImplementation : OverRiding
    {
        public void ImplementOverRiding()
        {
            int result = Sum(10, 20);

            Console.WriteLine("After OverRiding. " + result);
            Console.ReadLine();
        }

        public override int Sum(int num1, int num2)
        {
            return num1 * num2;
        }
    }
}
