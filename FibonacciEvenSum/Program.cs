using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciEvenSum
{
    class Program
    {
        /*Each new term in the Fibonacci sequence is generated
        by adding the previous two terms. By starting with
        1 and 2, the first 10 terms will be:

        1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...

        By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.*/


        static void Main(string[] args)
        {
            List<int> evens = new List<int>();
            int add = 1;
            int x = 0;

            for (int i = 1; i <= 4000000; i = x + add)
            {
                Console.WriteLine(i);
                x = add;
                add = i;
                if (i % 2 == 0)
                {
                    evens.Add(i);
                }               
            }
            Console.WriteLine();
            Console.Write("Sum of the evennumbers in this sequence is: ");
            Console.WriteLine(evens.Sum());
        }
    }
}
