using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha5
{
    struct Point
    {
        public Int32 a;
        public Int32 b;
    };
    class Program
    {
        static void Main(string[] args)
        {
            Int32 m;
            Point p;
            Double dist = 0.00;
            Double max;
            List<Point> Polygon = new List<Point>();
            List<Double> P = new List<Double>();
            Console.Write("Въведете броя на ъглите в многоъгълника: ");
            m = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                Console.Write("a= ");
                p.a = int.Parse(Console.ReadLine());
                Console.Write("b= ");
                p.b = int.Parse(Console.ReadLine());
                Polygon.Add(p);
            }
            for (int c = 0; c < m; c++)
            {
                for (int d = 0; d < m; d++)
                {

                    dist = Math.Sqrt(Math.Pow(Polygon[c].a - Polygon[d].a, 2) + Math.Pow(Polygon[c].b - Polygon[d].b, 2));
                    P.Add(dist);
                }
            }
            max = P[0];
            for (int count = 0; count < m; count++)
            {
                max = Math.Max(max, P[count]);
            }
            Console.Write(String.Format("Максималния диаметър на многоъгълника P е: {0:0.00}.", max));
            Console.ReadKey();
        }
    }
}
