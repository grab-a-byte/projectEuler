using System;
using System.Collections.Generic;
using System.Text;

namespace EulerProject
{
    class FibonacciEven
    {
        static public void Exeute()
        {
            Console.WriteLine(GetEvenSums(4000000));
        }

        static private int GetEvenSums(int maxValue)
        {
            int sum = 0;

            int count = 1;

            while (true)
            {

                var num = GetFibbonachi(count);

                if (num % 2 == 0)
                {
                    sum += num;
                }

                count++;

                if (num > maxValue)
                {
                    break;
                }
            }


            return sum;
        }

        static private int GetFibbonachi(int number)
        {
            int num = 0;

            if (number == 1 || number == 2)
                return 1; 

            int previousNum=1 , secondPreviousNumber=1 , total = 0;

            for (int i =3; i < number;  i ++)
            {
                total = previousNum + secondPreviousNumber;
                previousNum = secondPreviousNumber;
                secondPreviousNumber = total;
            }

            return total; 


            return num; 
        }

    }
}
