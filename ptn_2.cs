using System;

namespace PATTENS
{
    public class ptn_2
    {
        public static void Main(string[] args)
        {
            // point 1 - according to no of rows 
            for (int i = 1; i <= 5; i++)
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