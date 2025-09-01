using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CountMandF
    {
        static void Main1(String[] args)
        {
            int[] arr = new int[8];
            Console.WriteLine("enter array elements : ");
            for (int i = 0; i < arr.Length; i++) {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int males = 0;
            int females = 0;
            for(int i=0; i<arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    males++;
                }
                else
                {
                    females++;
                }
            }

            Console.WriteLine("No. of males is  : " + males);
            Console.WriteLine("No. of females is  : " + females);

        }
    }
}
