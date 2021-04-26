using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgorekGolichic
{
    class Program
    {
        static void Main(string[] args)
        {
            //28
            Console.WriteLine("Введите b");
            int b = Convert.ToInt32(Console.ReadLine());
            int p = 1;
            for (int i=1; i<=b; i++)
            {
                p = p * i;
            }
            Console.WriteLine(p);
            Console.ReadKey();
        }
    }
}
