using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" введите число ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int p = 1;
            int i = 0;

            for (i = a; i <= b; i++)
            {
                p = p * i;
            }
            Console.WriteLine(p);
            Console.ReadKey();
        }
    }
}
