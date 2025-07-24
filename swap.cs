// swap method 
using System;

namespace PATTENS
{
    public class swap
    {
        static void swapex(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("Inside swapex: a = {0}, b = {1}", a, b);
        }

        static void Main()
        {
            int a = 20, b = 10;
            Console.WriteLine("Before swap: a = {0} and b = {1}", a, b);
            swapex(a, b);  // ✅ fixed method call
            Console.WriteLine("After  swap: a = {0} and b = {1}", a, b);
        }
    }
}


