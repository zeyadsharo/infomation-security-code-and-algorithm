using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vigenere_cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 0;
            int j = 0;
            for (int i = 97; i < 123; i++)
            {
                Console.Write((char)(i) + " ");
                for (j = i; j < 123; j++)
                {
                    Console.Write((char)(j) + " ");
                    index++;
                }
                if (index < 26)
                {
                    for (int L = 97; L < 123 - index; L++)
                    {
                        Console.Write((char)(L) + " ");
                    }
                }
                index = 0;

                Console.WriteLine();
            }
            string plantext = "TELLHIMABOUTME";
            string key = "CAFE";
            for (int i = 0; i < plantext.Length; i++)
            {
                for (int T = 0; T < key.Length; T++)
                {
                    if (key.Length != plantext.Length)
                    {
                        key = key + key[T];
                    }
                }
            }
          //  char[]d=new char[plantext.Length];
            char[] plan = new char[plantext.Length] ;
            char[] ciphertext = new char[plantext.Length];
            for (int i = 0; i < plantext.Length; i++)
            {
              ciphertext[i] = Convert.ToChar(((plantext[i] + key[i]) % 26) + 65);
              //  cipher += (char)((plantext[i] + key[i]) - 65);
            }
            Console.Write("ciphertext: ");
            for (int i = 0; i < ciphertext.Length; i++)
            {
                Console.Write(ciphertext[i]);
            }
            //Console.Write("the cipher text:"+cipher);
            for (int i = 0; i < ciphertext.Length; i++)
            {
                plan[i]= Convert.ToChar((((ciphertext[i] - key[i]) + 26) %26)+65);
            }
            Console.WriteLine();
            Console.Write("plan text: ");
            for (int i = 0; i < plan.Length; i++)
            {
                Console.Write(plan[i]);
            }
            Console.ReadKey();
        }
    }
}

