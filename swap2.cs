using System;

public class swap2
{
    static void swap(ref int a, ref int b)// a and b both are local variable
    {
        //int temp = a;
        //a = b;
       // b = temp;
        a = a + b; // a = 30
        b = a - b; // b = 10
        a = a - b;
    }
    public static void Main(string[] args)
    {
        int a = 10, b = 20;
        Console.WriteLine("Before swap : a = {0} and b = {1}", a, b);
        swap(a, b);//passing the arguments by value
        swap(ref a, ref b);//passing the arguments by value
        Console.WriteLine("After swap : a = {0} and b = {1}", a, b);
    }
}