
/*444
 * 414
 * 424
 * 434
 * 444*/
using System;
namespace PATTENS
{
    public class four
    {
        public static void main(string[] args)
            int row = 1;
        while (row <= 5)
            {
            int col = 1;
        while (col <= 5)
                    {
            if (row == 1 || row == 5)
            {
            Console.Write("4");
            }
    else if (row == 3 && col == 3)
        {
        Console.Write("1");
        }
else if (row == 4 && col == 3)
{
    Console.Write("3");
}
else
{
    Console.Write("4");
}
col++;
}
Console.WriteLine();
row++;
}
}
}
}
