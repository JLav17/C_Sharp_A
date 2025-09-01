using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MultiplyByFactor
    {
        static void Main(String[] args)
        {
            Console.WriteLine("enter the array");
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("enter the factor : ");
            int factor = int.Parse(Console.ReadLine());
            for(int i=0; i < arr.Length; i++)
            {
                arr[i] *= factor;
            }

            Console.WriteLine(String.Join(" -> " , arr));
        }
    }
}
