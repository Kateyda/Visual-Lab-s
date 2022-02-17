using System;

public class HW
{
    static int index_min(long[] arr)
    {
        int min = 0;
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < arr[min]) min = i;
        }
        return min;
    }
    static long max_znachenie(long[] arr)
    {
        int max = 0;
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > arr[max]) max = i;
        }
        return arr[max];
    }
    public static long QueueTime(int[] customers, int n)
    {
        long[] arr = new long [n]; //массив значения времени касс
        long znachenie = 0;
        int index_arr;
        for (int i = 0; i < n; i++) 
            arr[i] = 0;
        for (int i = 0; i < customers.Length; i++)
        {
            index_arr = index_min(arr);
            arr[index_arr] += customers[i];
        }
        znachenie += max_znachenie(arr);
        return znachenie;
    }
}

class Program
{
    static void Main()
    {
        int[] kassa_test1 = {5,3,4};
        int[] kassa_test2 = {10,2,3,3};
        int[] kassa_test3 = {2,3,10};
        Console.WriteLine("Время на 1 тесте = " + HW.QueueTime(kassa_test1, 1));
        Console.WriteLine("Время на 2 тесте = " + HW.QueueTime(kassa_test2, 2));
        Console.WriteLine("Время на 3 тесте = " + HW.QueueTime(kassa_test3, 2));
        Console.ReadLine();
    }
}