using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class AverageOfArray
    {
        static void Main1(String[] args)
        {
            float[] arr = new float[5];
            Console.WriteLine("enter the array elements : ");

            for(int i =0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToSingle(Console.ReadLine());
            }

            float sum = 0;
            for (int i = 0; i < arr.Length; i++) {
                sum += arr[i];
            }

            Console.WriteLine(sum / arr.Length);
        }
    }
}
