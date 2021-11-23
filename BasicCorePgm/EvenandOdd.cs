using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePgm
{
   public class EvenandOdd
    {
        public void EvenOdd()
        {
            int n;
            Console.Write("ENTER THE NUMBER : ");
            n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.Write("Number is an Even Number");
                Console.Read();
            }
            else
            {
                Console.Write("Number is an Odd Number");
                Console.Read();
            }

        }
    }
}
