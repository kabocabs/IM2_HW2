using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            


            Console.Write("Enter row: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Enter col: ");
            int cols = int.Parse(Console.ReadLine());

        
            List<List<double>> matrix = new List<List<double>>();
            double sum = 0;

           
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine($"Row {i + 1}");
                List<double> row = new List<double>();

                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Enter number{j + 1}: ");
                    double num = double.Parse(Console.ReadLine());
                    row.Add(num);
                    sum += num;
                }
                matrix.Add(row);
            }

            // Display values
            Console.WriteLine("\nThe numbers are:");
            foreach (var row in matrix)
            {
                foreach (var val in row)
                {
                    Console.Write(val.ToString("0.0") + " ");
                }
                Console.WriteLine();
            }

            //  average
            double average = sum / (rows * cols);

            Console.WriteLine($"\nSum: {sum:0.0}; Average: {average:0.0}");
        }
    }
}
