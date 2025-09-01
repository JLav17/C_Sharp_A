namespace ConsoleApp1;
class SumOfArray
{
    static void Main1(String [] args)
    {
        int[] arr = new int[5];
        Console.WriteLine("enter array element : ");
        for (int i = 0; i < 5; i++) { 
            arr[i] = int.Parse(Console.ReadLine());
        }

        int sum = 0;
        for(int i=0; i < arr.Length; i++)
        {
            sum += arr[i];
        }

        Console.WriteLine(sum);
    }
}