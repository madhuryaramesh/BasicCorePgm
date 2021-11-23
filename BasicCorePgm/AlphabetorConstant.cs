using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePgm
{
    public class AlphabetorConstant
    {
        public void AlphabetCo()
        {
            char ch;
            Console.Write("\n\n");
            Console.Write("ALPHABET OR CONSTANT:\n");
            Console.Write("-----------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("ENETR THE ALPHABET : ");
            ch = Convert.ToChar(Console.ReadLine().ToLower());
            int i = ch;
            if (i >= 48 && i <= 57)
            {
                Console.Write("INVALID ENTRY");
            }
            else
            {
                switch (ch)
                {
                    case 'a':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'i':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'o':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'u':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'e':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    default:
                        Console.WriteLine("The Alphabet is a constant ");
                        break;
                }
            }
            Console.ReadKey();

        }
    }
}
