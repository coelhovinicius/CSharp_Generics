using System;

namespace Aula204_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintService printService = new PrintService();

            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                printService.AddValue(x); // Armazena o valor "x" digitado dentro do PrintService
            }

            printService.Print();
            Console.WriteLine("First: " + printService.First());
        }
    }
}
