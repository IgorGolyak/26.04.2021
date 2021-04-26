using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int b = Convert.ToInt32(Console.ReadLine());
            int s = 0;
            for (int i = 1; i <= 1000; i++)
            {
                s = s + i;
            }
            Console.WriteLine(s/1000.0);
            Console.ReadKey();
        }
    }
}
