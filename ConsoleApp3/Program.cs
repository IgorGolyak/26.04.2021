using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //5.32
            Console.WriteLine("Введите число");
            int n = Convert.ToInt32(Console.ReadLine());
            double s = 0;
            for (int i = 1; i <= n; i++)
            {
                s = s+1.0/i;
            }
            Console.WriteLine(s);
            Console.ReadKey();


        }
    }
}
