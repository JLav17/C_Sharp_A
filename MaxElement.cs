using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MaxElement
    {
        static void Main1(String[] args)
        {
            Console.WriteLine("enter the array elemnts : ");
            int[] arr = new int[5];
            for(int i =0; i<arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int max = int.MinValue;
            for (int i = 0; i < arr.Length; i++) {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine(max);
        }
    }
}
