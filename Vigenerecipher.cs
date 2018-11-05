using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vigenere_cipher
{
    class Program
    {
        static void vigenerecipher()
        {
            Console.Write("Enter the plan text: ");
            string plantext = Console.ReadLine();
            Console.Write("Enter the key: ");
            string key = Console.ReadLine();
            string ciphertext = "";
            for (int i = 0; i < plantext.Length; i++)
                ciphertext += (char)(((plantext[i] - 'a') + (key[i % key.Length] - 'a')) % 26 + 'a');
            Console.WriteLine("the cipher text: " +ciphertext);
        }
        static void stylechar()
        {
                for (int i = 0; i < 26; i++)
                {
                    for (int j = i; j <26+i ; j++)
                    {
                        Console.Write((char)(j%26+'a')+ " ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();
            }

        static void Main(string[] args)
        {

            stylechar();
            vigenerecipher();

           
            Console.ReadKey();
        }
    }
}

