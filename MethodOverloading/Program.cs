using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class Program
    {
        void sum (int a,int b)
        {
            Console.WriteLine( a + b);
        }
        void sum (float a, float b)
        {
            Console.WriteLine ( a + b);
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.sum(10.2f, 20f);
            Console.ReadLine();
        }
    }
}
