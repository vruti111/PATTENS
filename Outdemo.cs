using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATTENS
{
    internal class Outdemo
    {
        static void Change(ref int a, ref int b)
        {
            a = 100;
            b = 200;

        }
        static void Update(out int a, out int b)
        {
            a = 100;
            b = 200;

        }
        static void Main()
        {
            int a = 10, b = 20;
            int x = 10, y = 20;
            Console.WriteLine("Before swap: a={0} and b={1}", a, b);
            Change(ref a, ref b);
            Console.WriteLine("After swap: a={0} and b={1}", a, b);

            Console.WriteLine("Before Update: x={0} and y={1}", x, y);
            Change(ref a, ref b);
            Console.WriteLine("After Update: x={0} and y={1}", x, y);
        }
    }
}
