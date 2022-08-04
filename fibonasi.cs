using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
   public static class fibonasi
    {
        public static void CalculateFibonaciiSeries()
        {
            int number,n1=0, n2=1,sum=0,i;

            Console.WriteLine("Enter the number of elements: ");
            number = int.Parse(Console.ReadLine());
            Console.Write(n1 + " " + n2 + " ");
            for (i = 2; i < number; i++)
            {
                sum =   n1 + n2;
                //Console.Write only write value on console in sinlge line dont goton new line. 
                Console.Write(sum + " ");
                n1 = n2;
                n2 = sum;
            }

        }
    }
}
