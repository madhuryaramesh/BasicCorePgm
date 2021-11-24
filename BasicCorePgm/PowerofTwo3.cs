using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePgm
{
    public class PowerofTwo3
    {
        public void Powo21()
        {

           

            int value = 2, n, power;
            double res;

            Console.Write("ENTER THE LIMIT \n");
            n = Convert.ToInt32(Console.ReadLine());

            for (power = 1; power <= n; power++)
            {
                 res = Math.Pow(value, power);
                 Console.WriteLine(+value + " * " + power + " = " + res);

            }

        }
    }
}
