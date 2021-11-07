using System;
using static System.Console;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int [5, 5];
            for (var i = 0; i < 5; i++)
                for (var j = 0; j < 5; j++)
                    array[i, j] = i + j;
            for (var i = 0; i < 5; i++)
            {
                for (var j = 0; j < 5; j++)
                    Console.Write(array[i, j] + " ");
                Console.WriteLine(" ");
            }

            Console.WriteLine($"Введите число в интервале от -4 до 4");
            string W = ReadLine();

            if (!int.TryParse(W, out var z))
            {
                Console.WriteLine("Некорректный ввод!");
                return;
            }
                if (z <= -5 || z >= 5)
            {
                Console.WriteLine("Номер указан не верно!");
                return;
            }

            int number = z < 0 ? Math.Abs(z) : z;
            var T = 5 - Math.Abs(z);
            for (int i = 0, j = 0; i < T || j < T; i++, j++)
            {
                var w = z switch
                {
                    0 => array[i, j],
                    < 0 => array[i, j + number],
                    _ => array[i + number, j]
                };
                Console.Write(w + " ");
            }
        }
    }
}