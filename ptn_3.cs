using System;

namespace PATTENS
{
    public class ptn_3
    {
        public static void Main(string[] args)
        {
            // point 1 - according to no of rows 
            for (int i = 5; i <= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}