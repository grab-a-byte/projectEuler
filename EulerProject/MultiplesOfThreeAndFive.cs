using System;
using System.Collections.Generic;
using System.Text;

namespace EulerProject
{
    class MultiplesOfThreeAndFive
    {

        // get the sum of all the multiples of 3 and 5 below a given number. 

        static public void Execute()
        {
            Console.WriteLine("Below 10 : " + GetSum(10));

            Console.WriteLine("Below 1000 : " + GetSum(1000));
        }

        static private int GetSum(int maxValue)
        {
            int sum = 0;

            for (int i = 0; i < maxValue; i++)
            {
                if ((i % 3 == 0) || (i % 5 == 0))
                {
                    sum += i;
                }

            }

            return sum;

        }


    }
}
