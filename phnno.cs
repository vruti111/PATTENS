using System;
namespace PATTENS
{

    public class phnno
    {
        public static void Main(string[]args)
        {
            Console.Write("Enter your mobile number: ");
            string mobile = Console.ReadLine();

            if (mobile.Length >= 10)
            {
                
                string visiblePart = mobile.Substring(0, mobile.Length - 5);

                
                string hiddenPart = new string('X', 5);

          
                string result = string.Concat(visiblePart, hiddenPart);

                Console.WriteLine("Masked Mobile No: " + result);
            }
            else
            {
                Console.WriteLine("Please enter at least 10-digit mobile number.");
            }
        }
    }
}