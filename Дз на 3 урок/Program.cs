using static System.Console;

namespace HW
{
    class Program
    {
        static void Main(string[] args)
        {
            var contacts = new string[5, 2]
            {
                {"Серега", "       +7 913 123 11 10"},
                {"Андрей", "       +7 913 664 88 12"},
                {"Григорий", "     +7 913 331 40 32"},
                {"Виктор", "       vitek272@mail.ru"},
                {"Олег Работа", "  olegovoleg1@mai.ru"},
            };
            for (var i = 0; i < contacts.GetLength(0); i++)
            {
                for (var j = 0; j < contacts.GetLength(1); j++)
                    Write(contacts[i, j] + " ");
                WriteLine();
            }
            ReadLine();
        }
    }
}