using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter demand");
            decimal demand0 = decimal.Parse(Console.ReadLine());
            Console.Write("Enter demandunit");
            decimal demandunit = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter initial cost");
            decimal costinitial = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter costunit");
            decimal costunit = decimal.Parse(Console.ReadLine());
            decimal a = -demandunit;
            decimal b = costunit * demandunit + demand0;
            decimal c = -costunit * demand0 - costinitial;
            decimal priceunit = (-(b / (2 * a)));
            decimal profit = a * priceunit + b * priceunit + c;
            Console.WriteLine(priceunit);
            Console.WriteLine(profit);


        }
    }
}
