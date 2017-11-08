using System;
using System.Collections.Generic;
using System.Text;

namespace EulerProject
{
    class PalindromicNumber
    {
        public static void Execute()
        {
            int highestPalindrome = 0;

            for (int i = 100; i < 1000; i ++)
            {
                for (int x = i; x < 1000; x ++)
                {
                    int product = i * x;

                    if (isPalindromic(product))
                    {
                        //check if higher
                        if (product > highestPalindrome)
                        {
                            highestPalindrome = product;
                        }
                    }

                }
            }

            Console.WriteLine("Highest palindrome = " + highestPalindrome);
        } // Execute()

        public static bool isPalindromic(int number)
        {
            string ourNumber = number.ToString();

            var ourArray = ourNumber.ToCharArray();

            Array.Reverse(ourArray);

            string reversed = "";
            foreach(char c in ourArray)
            {
                reversed += c;
            }

            if (ourNumber == reversed)
            {
                return true;
            }

            else
            {
                return false; 
            }
        }

    }
}
