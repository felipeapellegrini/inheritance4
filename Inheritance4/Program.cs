using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inheritance4.Entities;

namespace Inheritance4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of Tax Payers: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company? (i/c): ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Income: ");
                double anualIncome = double.Parse(Console.ReadLine());
                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine());

                    list.Add(new Individual(healthExpenditures, name, anualIncome));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());

                    list.Add(new Company(name, anualIncome, numberOfEmployees));
                }
            }
            Console.WriteLine();

            Console.WriteLine("TAXES PAYD");
            double sum = 0;

            foreach (TaxPayer x in list)
            {
                Console.WriteLine(x.Name + ": $" + x.Tax().ToString("F2"));
                sum += x.Tax();
            }

            

          
            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $" + sum.ToString("F2"));
        }
    }
}
