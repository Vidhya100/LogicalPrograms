using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public static class PerfectNumber
    {
        public static void CalculatePerfectNumber() 
        {
            int n, i, sum, min, max;

            Console.WriteLine("Input the starting range or number: ");
            min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the ending range of Number: ");
            max= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The perfect numbers within the givn range: ");

            for (n = min; n <= max; n++)
            {
                i = 1;
                sum = 0;
                while (i < n)
                {
                    if (n % i == 0)
                    {
                        sum = sum + i;

                    }
                    i++;
                }
                if(sum == n)
                {
                    Console.WriteLine("{0} , ", n);
                }
            }
        }
    }
}
