using System;
using Final_exercice.Entities;
using System.Globalization;
using System.Collections.Generic;
namespace Final_exercice
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            List<TaxPayer> list = new List<TaxPayer>();
            Console.Write("Enter the number of tax payers: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine().ToLower());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Income: ");
                double income = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                if (ch == 'c')
                {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, income, employees));
                }
                else
                {
                    Console.Write("Health expenditures: ");
                    double healt = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, income, healt));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");
            foreach (TaxPayer x in list)
            {
                Console.WriteLine(x.Name + ": " + x.tax().ToString("F2",CultureInfo.InvariantCulture));
                total += x.AnualIncome;
            }

            Console.WriteLine();
            Console.Write("TOTAL TAXES: " + total.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
