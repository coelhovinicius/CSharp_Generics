using System;

namespace Aula204_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            // PrintService printService = new PrintService();
            // PrintService<string> printService = new PrintService<string>();
            PrintService<int> printService = new PrintService<int>();
            // PrintServiceString printService = new PrintServiceString();

            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                // string x = (Console.ReadLine());
                printService.AddValue(x); // Armazena o valor "x" digitado dentro do PrintService
            }

            int a = printService.First();
            int b = a + 2;
            Console.WriteLine(b);

            printService.Print();
            Console.WriteLine("First: " + printService.First());
        }
    }
}
