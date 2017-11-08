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

        public static void GeneratePrimeNumbers(Int64 limit)
        {
            
            List<Int64> primeList = new List<Int64>();

            primeList.Add(2);
            primeList.Add(3);

            bool isPrime = true;

            for (Int64 i = 4; i < limit; i ++)
            {
                for (Int64 z= 2; z< i; z++)
                {
                    if ((double)i%z == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    primeList.Add(i);
                }

                Console.WriteLine("Processed: " + i + " :- " + (double)i/limit + " %");

                isPrime = true;

            }

            System.IO.File.WriteAllText("primes.txt", String.Join(",", primeList));

            Console.WriteLine("Primes Calculated");
        }
    }
}
