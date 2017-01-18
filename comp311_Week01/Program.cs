using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp311_Week01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int a = 1, b = 2, c;
            //runtime errors
            // c = a / b;
            c = add(a, b);
            Console.WriteLine("c = 1 + 2 = " + c);
        }
        /**
         @method add
         @return => int
         @params => a : int, b : int
         */
         static int add(int a,int b)
        {
            return a + b;
        }
    }
}
