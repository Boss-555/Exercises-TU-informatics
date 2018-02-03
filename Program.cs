using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanoi
{
    class HanTowers
    { 
        static void Hanoi(int n, int a, int b, int c)
        {
            if(n>0)
            {
                Hanoi(n - 1, a, c, b);
                Console.WriteLine("Move to disc {0} to {1}", a, c);
                Hanoi(n - 1, b, a, c);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Брой дискове: ");
            int n = int.Parse(Console.ReadLine());
            int a = 1;
            int b = 2;
            int c = 3;
            Hanoi(n, a, b, c);
        }
    }
}
