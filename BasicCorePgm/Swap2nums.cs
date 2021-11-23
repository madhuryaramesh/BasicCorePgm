using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePgm
{
   public class Swap2nums
    {
        public void Swap()
        {
            int num1, num2, temp;
            Console.Write("\nENTER NUMBER 1 : ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("\nENTER NUMBER 2 : ");
            num2 = int.Parse(Console.ReadLine());
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.Write("\nNUMBERS AFTER SWAPPING : ");
            Console.Write("\nFINAL FIRST NUMBER : " + num1);
            Console.Write("\nFINAL SECOND NUMBER : " + num2);
            Console.Read();

        }
    }
}
