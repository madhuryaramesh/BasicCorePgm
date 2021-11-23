using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePgm
{
    public class Harmonic4
    {
        public void Harmonic()
        {
            

            int i, n;
            double sum = 0;
            double r;
            Console.Write("\n\n");
            Console.Write("HARMONIC SERIES OF THE GIVEN NUMBER AND THEIR SUM IS :\n");
            Console.Write("----------------------------------------------");
            Console.Write("\n\n");

            Console.Write("ENTER THE LIMIT : ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                Console.Write("1/{0} + ", i);
                sum =sum+ 1 / (double)i;
            }
            r = Convert.ToDouble(sum);
            Console.Write("\nSum of Series upto " +n+ " terms : {1} \n", n, r);


        }
    }
}
