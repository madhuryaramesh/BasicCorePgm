using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePgm
{
    public class QuoandRem
    {
        public void QR()
        {
            //int dividend = 50, divisor = 8;
            Console.WriteLine("Enter the Dividend value - ");
            int dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Divisor value - ");
            int divisor = Convert.ToInt32(Console.ReadLine());
            int quotient = dividend / divisor;
            int remainder = dividend % divisor;
            Console.WriteLine("Dividend:{0} Divisor:{1}", dividend, divisor);
            Console.WriteLine("Quotient is = " + quotient);
            Console.WriteLine("Remainder is = " + remainder);
            Console.ReadLine();

        }
    }
}
