using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            double k = double.Parse(Console.ReadLine());
            double s = 1;
            for (double i = 1; i <= k + 1; i++)
            {
                if (i % 2 == 0)
                {
                    s *= i / (i + 1);
                }
                else
                {
                    s *= (i + 1) / i;
                }
                Console.WriteLine(s);
            }
        }
    }
}
