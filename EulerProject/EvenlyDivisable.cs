using System;
using System.Collections.Generic;
using System.Text;

namespace EulerProject
{
    class EvenlyDivisable
    {
        public static void Execte()
        {
            int finalValue = 0;
            int counter = 20;
            bool isWorking = true ;

            while(true)
            {
                for (int i = 1; i <=20; i ++)
                {
                    if(counter % i != 0)
                    {
                        isWorking = false;
                        break;
                    }

                }
                if (isWorking)
                {
                    finalValue = counter;
                    break;
                }

                Console.WriteLine("Processed Value: " + counter);

                counter++;
                isWorking = true;
            }

            Console.WriteLine("Highest Num = " + finalValue);

        }

    }
}
