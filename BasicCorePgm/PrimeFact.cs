using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePgm
{
    public class PrimeFact
    {
        public void PrimeF()
        {

            int n, fact;
            Console.WriteLine("ENTER THE NUMBER : \n");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("FACTORS ARE : \n");
            for (fact = 1; fact <= n; fact++)
            {
                if (n % fact == 0)
                {
                    Console.WriteLine(fact);
                }
            }


        }
    }
}
