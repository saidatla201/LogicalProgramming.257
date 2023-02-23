using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramms
{
    public class PerfectNumber
    {
        public static void GetPerfectNumber()
        {
            int sumOfFactors = 0; int i = 1;
            Console.WriteLine("Enter a Number to check perfect Number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            while (i < number)
            {
                if (number % i == 0)
                {
                    sumOfFactors += i;
                    Console.WriteLine(i);
                }
                i++;
            }
            Console.WriteLine("Sum of factors :" + sumOfFactors);
            if (sumOfFactors == number)
            {
                Console.WriteLine("{0} is a Perfect Number", number);
            }
            else
            {
                Console.WriteLine("{0} is not a Perfect Number", number);
            }
        }
    }
}
