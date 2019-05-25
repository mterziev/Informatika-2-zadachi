using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mnogougulnik
{
    class Program
    {
        static void Main(string[] args)
        {
            double max = -1;
            double maxXpk = 0;
            double maxYpk = 0;
            double maxXpl = 0;
            double maxYpl = 0;
            int pk = 0;
            int pl = 0;

            Console.Write("Въведете n полигон: ");
            int n = int.Parse(Console.ReadLine());
            double[] x = new double[n];
            double[] y = new double[n];
            
            for (int i = 1; i <= n; i++)
            {
                Console.Write("Въведете стойност за x" + i + ": ");
                x[i - 1] = double.Parse(Console.ReadLine());
                Console.Write("Въведете стойност за y" + i + ": ");
                y[i - 1] = double.Parse(Console.ReadLine());
            }
            for (int i = 1; i < n; i++)
            {
                for (int j = i + 1; j <= n; j++)
                {
                    double newmax = Math.Sqrt((x[i - 1] - x[j - 1]) * (x[i - 1] - x[j - 1]) + (y[i - 1] - y[j - 1]) * (y[i - 1] - y[j - 1]));
                    if (newmax > max)
                    {
                        max = newmax;
                        pk = i;
                        pl = j;
                        maxXpk = x[i - 1];
                        maxYpk = y[i - 1];
                        maxXpl = x[j - 1];
                        maxYpl = y[j - 1];
                    }
                }
                
            }
            Console.WriteLine("Максимален диагонал: " + max);
            Console.WriteLine("Първа точка: " + pk + " Втора точка: " + pl);
            Console.WriteLine("x за първата точка: " + maxXpk + " y за първата точка: " + maxYpk);
            Console.WriteLine("x за втората точка: " + maxXpl + " y за втората точка: " + maxYpl);
            Console.ReadLine();
        }
    }
}
