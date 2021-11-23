using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePgm
{
    public class FlipCoin1
    {
        public void FC1()
        {
			int hnum = 0;
			int tnum = 0;
			int n;
			double heads, tails;
			Console.WriteLine("Enter number of times");
			n = Convert.ToInt32(Console.ReadLine());

			for (int i = 0; i < n; i++)
			{
				double ran;
				Random random = new Random();
				double r = random.Next(0, 2);
				ran = Convert.ToDouble(r);
				Console.WriteLine(ran);
				if (ran < 0.5)
				{
					Console.WriteLine("tails");
					tnum = tnum + 1;
					ran++;
				}
				else
				{
					Console.WriteLine("heads: ");
					hnum = hnum + 1;
					ran++;
				}
			}
			Console.WriteLine("-------------------------");
			Console.WriteLine("Head count" + hnum);
			Console.WriteLine("Tail count" + tnum);
			Console.WriteLine("-------------------------");
			heads = hnum / (double)n * 100;
			tails = tnum / (double)n * 100;
			Console.WriteLine(" HEADS PERCENTAGE IS  " + heads + "%");
			Console.WriteLine(" TAILS PERCENTAGE IS  " + tails + "%");
		}
    }
}
