/*333
 * 313
 * 323
 * 333*/




using System;
namespace PATTENS

public class three
{
    public static void main(string[] args)
                int row = 1;

                while (row <= 4)
                {
                    int col = 1;
                    while (col <= 3)
                    {
                        if (row == 1 || row == 4)
                        {
                            Console.Write("3");
                        }
                        else if (row == 2 && col == 2)
                        {
                            Console.Write("1");
                        }
                        else if (row == 3 && col == 2)
                        {
                            Console.Write("2");
                        }
                        else
                        {
                            Console.Write("3");
                        }

                        col++;
                    }
                    Console.WriteLine();
                    row++;
                }
            }
        }

    }
}




