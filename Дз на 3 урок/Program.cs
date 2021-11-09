using System;
namespace HW3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Напиши что нибудь ");
                string str = Console.ReadLine();
                Console.WriteLine(ReversStr(str));
                Console.ReadLine();
            }
            static char[] ReversStr(string str)
            {
                char[] massiv = new char[str.Length];
                int j = str.Length - 1;
                for (int i = 0; i < str.Length / 2; i++)
                {
                    massiv[i] = str[j];
                    j--;
                }
                j = 0;
                for (int i = str.Length - 1; i >= str.Length / 2; i--)
                {
                    massiv[i] = str[j];
                    j++;
                }
                return massiv;
            }
        }
    }
}