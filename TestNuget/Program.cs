using NugetDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNuget
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            MyMath math = new MyMath();
            Console.Write("a+b={0}", math.Add(a, b));
            Console.ReadKey();

        }
    }
}
