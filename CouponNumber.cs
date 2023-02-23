using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramms
{
    public  class CouponNumber
    {
        public static void GetCouponNumbers()
        {
            int coupon;
            Console.WriteLine("Enter a Number of Coupons Required : ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                coupon = GetRandomNum();
                Console.WriteLine(coupon);
            }
        }
        public static int GetRandomNum()
        {
            Random random = new Random();
            random.Next();
            return random.Next();
        }
    }
}
