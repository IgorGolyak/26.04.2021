using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5.29 a
            int s = 0;
            for (int i=1; i<=1000; i++)
            {
                s = s + i;
            }
            double sr = s / 1000.0;
            Console.WriteLine(sr);
            Console.ReadKey();

        }
    }
}
