using System;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //caesar ciphier
            string key = "ctaxqhjfkgilvzpoesrbwmudyn";
            Console.Write("Enter the plantext palse: ");
            string plantext = Console.ReadLine();
            string cipher = "";
            for (int i = 0; i < plantext.Length; i++)
            {
                if (plantext[i] == ' ')
                    cipher += ' ';
                else
                    cipher += key[plantext[i] - 97];
            }
            Console.WriteLine("the cipher text is: " + cipher);
            Console.WriteLine((int)'e');
            Console.Write("Enter the ciphertext palse: ");
            string ciphertext = Console.ReadLine();
            string plantexts = "";
            for (int i = 0; i < ciphertext.Length; i++)
            {
                plantexts += (char)(key.IndexOf(ciphertext[i]) + 97);
            }
            Console.WriteLine("the plantext is: " + plantexts);

            Console.ReadLine();


        }
    }
}
