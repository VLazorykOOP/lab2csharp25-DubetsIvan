using System;

class Program_2
{
    static void Main2(string[] args)
    {
        Console.WriteLine("Введiть розмiр масиву");
        int size = int.Parse(Console.ReadLine());
        Random rand = new Random();
        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            arr[i] = rand.Next(1, 101);
            Console.WriteLine(arr[i]);
        }
        int max = arr[0];
        int max_i = 0;
        for (int i = 0;i < size; i++)
        {
            if (max < arr[i])
            {
                max = arr[i];
                max_i = i;
            }
        }
        Console.WriteLine("Max: " + max + " Index: " + max_i);
        int min = arr[0];
        int min_i = 0;
        for (int i = 0; i < size; i++)
        {
            if (min > arr[i])
            {
                min = arr[i];
                min_i = i;
            }
        }
        Console.WriteLine("Min: " + min + " Index: " + min_i);
        int sum = 0;
        for(int i = min_i;  i <= max_i; i++) {
            sum += arr[i];
        }
        Console.WriteLine(sum);
    }
}