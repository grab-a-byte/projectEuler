using System;
using System.Collections.Generic;
using System.Text;

namespace EulerProject
{
    class Class1
    {

        public static void Run()
        {
            int count = 0;

            for (int i =0; i <=1000; i ++ )
            {
                if ((i % 2 != 0))
                {
                    if (i%3 != 0)
                    {
                        if (i%5 != 0)
                        {
                            count++;
                        }
                    }         
                }
            }

            Console.WriteLine(count);
        }
    }
}
