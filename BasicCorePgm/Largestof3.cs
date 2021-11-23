using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePgm
{
    public class Largestof3
    {
        public void Largest()
        {
            int num1, num2, num3;
            Console.Write("\n\n");
            Console.Write("LARGEST OF 3 NUMBERS :\n");
            Console.Write("------------------------------------");
            Console.Write("\n\n");

            Console.Write("ENTER THE NUMBER 1 :");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("ENTER THE NUMBER 2 :");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("ENTER THE NUMBER 3 :");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("The Number 1 is the Largest. \n\n");
                }
                else
                {
                    Console.Write("The Number 2 is the Largest. \n\n");
                }
            }
            else if (num2 > num3)
                Console.Write("The Number 2 is the Largest. \n\n");
            else
                Console.Write("The Number 3 is the Largest. \n\n");

        }
    }
}
