using System;
namespace PATTENS
{
    public class ptn_5
    {
        public static void Main (string[] args)
        {
            for (int i = 1; i <= 9; i++)
            {
                int arrow = i <= 5 ? i : 10 - i;
                Console.WriteLine(new string('*', arrow));
            }
        }

    }
}

