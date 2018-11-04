using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            //convert plantext to ciphertext
            Console.WriteLine("convert plantext to ciphertext..");
            Console.Write("Enter your plantext: ");
            string plan = Convert.ToString(Console.ReadLine());
            string cipher = "";
            string  plantext = "";
            Console.Write("Enter key: ");
            int key = int.Parse(Console.ReadLine());
            for (int i = 0; i < plan.Length; i++)
            {
                cipher += (char)(((((int)(plan[i])) - 97 + key) % 26) + 97);      
            }
            //convert cipher text to plan text
            for (int i = 0; i < cipher.Length; i++)
            { 
                plantext += (char)(((((int)(cipher[i])) - 97 - key) % 26) + 97);
            }
            Console.WriteLine("the text {0} cipher text is: {1}",plan,cipher);
            Console.WriteLine("the text {0} plantext text is: {1}", cipher, plantext);
            Console.WriteLine((int)'c');
            Console.ReadKey();
        }
    }
}
