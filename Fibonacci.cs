using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramms
{
    public class Fibonacci
    {
        public static void GetFibonacciSeries()
        {
            int num1 = 0, num2 = 1, num3;
            Console.WriteLine("Enter a number : ");
            int count = Convert.ToInt32(Console.ReadLine());
            Console.Write(num1 + "," + num2);
            for (int i = 2; i <= count; i++)
            {
                num3 = num1 + num2;
                Console.Write("," + num3);
                num1 = num2;
                num2 = num3;
            }
        }
    }
}
