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
            int n = int.Parse(Console.ReadLine());
            int fn = 1;
            for (int i = 1; i <= n; ++i)
                fn *= i;
            Console.WriteLine("{0}! = {1}", n, fn);
            Console.ReadLine(); 
        }
    }
}
