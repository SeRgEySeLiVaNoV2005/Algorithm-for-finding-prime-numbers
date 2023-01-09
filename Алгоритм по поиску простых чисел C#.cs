using System;
using System.Collections.Generic;   

namespace PrimeNumbers
{
    class Point
    {    
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            var AFiniteNumber = input;
            List<int>list = new List<int>();
            list.Add(2);
            for (var i = 3; i == AFiniteNumber; i += 2)
            {
               var k = 0;
               var q = Math.Pow(AFiniteNumber,0.5);
               for(var j = list[i]; ;)
                {
                    if(j > q)
                    {
                        break;
                    }
                    if(i % j == 0)
                    {
                        k = 1;
                        break;
                    }
                }
               if(k == 0)
                {
                    list.Add(i);
                }
            Console.WriteLine(i);
            Console.ReadLine();
            }
        
            

        }
            
            

    }
}

