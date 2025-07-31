using System;

namespace PATTENS
{
    class MethodOverloadding
    {
        public int add(int a, int b)
        {
            return a + b;
        }

        public int add(int a, int b, int c)
        {
            return a + b + c;
        }
        public static void Main()
        {
            MethodOverloadding over = new MethodOverloadding();

            Console.WriteLine("Sum of 10 + 20 = " + over.add(10, 20));
            Console.WriteLine("Sum of 10 + 20 + 30 = " + over.add(10, 20, 30));
        }
    }
}


/*using System;

namespace PATTENS
{
    class MethodOverloadding
    {
void sum (int x , int y )
{
}
int  sum (int x , int y )
{
}
 public static void Main()
*/
