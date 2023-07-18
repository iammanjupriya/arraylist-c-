using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace array_list
{
    public class Exercise3
    {
        public static void Main()
        {
            int[] a = new int[100];
            int i, n, sum = 0;   

            Console.Write("the number of elements on the list  :");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("elements in the array :", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element {0} : ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                sum += a[i];
            }

            Console.Write("Sum of all elements stored in the array is : {0}\n\n", sum);
        }
    }

}