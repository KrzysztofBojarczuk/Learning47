using System;

namespace Miesięczny_raport_sprzedaży
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadź wartość miesięczną sprzedaży.");
            double sales = double.Parse(Console.ReadLine());

            double countyTax = sales * 0.02;
            double stateTax = sales * 0.04;

            double totalTax = countyTax + stateTax;


            Console.WriteLine($" Wartość podateku naliczonego w hrabstwie wynosi {countyTax}.");
            Console.WriteLine($"Wartość podateku w stanie wynosi {stateTax}.");
            Console.WriteLine($"Całkowita wartość podatku wynosi {totalTax}.");
        }
    }
}
