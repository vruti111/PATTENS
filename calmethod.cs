//create add one method to add two numbers and return result given for addition numberr

using System;

namespace PATTENS
{

    public class calmethod
    {
        static int Add(int a, int b);
		{//public static void Main(string[] args)
        return a+b;
        }
        static int Sub(int a, int b);
		{
        return a-b;
        }
        static int Mul(int a, int b);
		{
        return a*b;
        }
        static int Div(int a, int b);
		{
        return a/b;
        }
            static void main() // static 
            
            int a = 20, b = 10;
            int ra;
            ra = Add(a, b);//test2 is bbelow to class with single topic varible copy is only 
            Console.WriteLine("addtion :"+ ra);
            ra = Sub(a, b);
            Console.WriteLine("subtraction:"+ra);
            ra = Mul(a, b);
            Console.WriteLine("Multiplication:"+ra);
            ra = Div(a, b);
            Console.WriteLine("Divison:"+ra);

     }
}



