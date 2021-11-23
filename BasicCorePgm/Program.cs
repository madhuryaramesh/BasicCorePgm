using System;

namespace BasicCorePgm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BASIC CORE PROGRAMMING");
            Console.WriteLine("-----------------------");

            //UC1
            //FLIP COIN
            Console.WriteLine("FLIP COIN PROGRAM");
            Console.WriteLine("-----------------------");
            FlipCoin1 flipCoin1 = new FlipCoin1();
            flipCoin1.FC1();
            Console.WriteLine("-----------------------");

            //UC2
            //LEAP YEAR
            Console.WriteLine("LEAP YEAR PROGRAM");
            Console.WriteLine("-----------------------");
            LeapYear leapYear = new LeapYear();
            leapYear.LP2();
            Console.WriteLine("-----------------------");

            //UC3
            
            //POWER OF 2
            //Console.WriteLine("POWER OF TWO");
            //Console.WriteLine("-----------------------");
            //PowerofTwo3 powerofTwo3 = new PowerofTwo3();
            //powerofTwo3.Powo21();
            //Console.WriteLine("-----------------------");

            //UC4
            //HARMONIC SERIES
            Console.WriteLine("Harmoic Series");
            Console.WriteLine("-----------------------");
            Harmonic4 harmonic4 = new Harmonic4();
            harmonic4.Harmonic();
            Console.WriteLine("-----------------------");

            //UC5
            //PRIME FACTORIZATION
            //Console.WriteLine("Harmoic Series");
            //Console.WriteLine("-----------------------");
            //PrimeFact primeFact = new PrimeFact();
            //primeFact.PrimeF();
            //Console.WriteLine("-----------------------");

            //UC6
            //QUOTIENT AND REMAINDER
            Console.WriteLine("Quotient and Remainder");
            Console.WriteLine("-----------------------");
            QuoandRem quoandRem = new QuoandRem();
            quoandRem.QR();
            Console.WriteLine("-----------------------");

            //UC7
            //SWAP 2 NUMBERS
            Console.WriteLine("Swap 2 Numbers");
            Console.WriteLine("-----------------------");
            Swap2nums swap = new Swap2nums();
            swap.Swap();
            Console.WriteLine("-----------------------");

            //UC8
            //EVEN OR ODD
            Console.WriteLine("Even Or Odd Number");
            Console.WriteLine("-----------------------");
            EvenandOdd evenandOdd = new EvenandOdd();
            evenandOdd.EvenOdd();
            Console.WriteLine("-----------------------");
            Console.ReadLine();

            //UC9
            //ALPHABET OR CONSTANT
            Console.WriteLine("Alphabet or a Constant");
            Console.WriteLine("-----------------------");
            AlphabetorConstant alphabetorConstant = new AlphabetorConstant();
            alphabetorConstant.AlphabetCo();
            Console.WriteLine("-----------------------");

            //UC10
            //LARGEST OF 3
            Console.WriteLine("Largest of 3");
            Console.WriteLine("-----------------------");
            Largestof3 largestof3 = new Largestof3();
            largestof3.Largest();
            Console.WriteLine("-----------------------");


        }
    }
}
