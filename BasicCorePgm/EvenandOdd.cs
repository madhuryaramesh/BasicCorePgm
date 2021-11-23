using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePgm
{
   public class EvenandOdd
    {
        public void EvenOdd()
        {
            int i;
            Console.Write("ENTER THE NUMBER : ");
            i = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
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
