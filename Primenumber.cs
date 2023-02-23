using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramms
{
    public  class Primenumber
    {
        public static void PrimeNum()
        {
            int Prime = 1;
            Console.WriteLine("Enter the number ");

            int number = Convert.ToInt32(Console.ReadLine());
            
            for(int i=2;i<=number/2;i++)
            {
                if(number %i==0)
                {
                    Prime = 0;
                }
            }
            if(Prime ==1)
            {
                Console.WriteLine("It's a Prime Number");
            }
            else
            {
                Console.WriteLine("It's not a Prime Num");
            }
        }
    }
}
