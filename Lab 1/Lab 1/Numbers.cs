using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_1
{
    public class Numbers
    {
        public void PlayWithNumbers()
        {
            int max = Int32.MaxValue;
            int min = Int32.MinValue;

            Console.WriteLine($"Min Value: {min} and Max Value: {max}");
            Console.WriteLine($"Min Value: {min - 1} and Max Value: {max + 1}");

            //Type Casting
            int IntegerNumber = 10;
            double DoubleNumber = 10.5;

            Console.WriteLine("Int to Double Conversion: " + Convert.ToDouble(IntegerNumber));
            Console.WriteLine("Double to Int Conversion: " + Convert.ToInt32(DoubleNumber));

            //Calculate Area of Circle
            double radius = 2.5;
            double area = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine($"Area of the Circle: {area}");

            Console.ReadLine();
        }
    }
}
