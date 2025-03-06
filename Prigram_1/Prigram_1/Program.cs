using System;

class Program_1
{
    static void Main1(string[] args)
    {
        Random rand = new Random();
        Console.WriteLine("Введiть розмiр масива: ");
        int size = int.Parse(Console.ReadLine());
        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            arr[i] = rand.Next(1, 101);
            Console.WriteLine(arr[i]);
        }
        Console.WriteLine("Введiть iтервал (a-b)");
        Console.WriteLine("a: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("b: ");
        int b = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = a - 1; i < b; i++)
        {
            sum += arr[i];
        }
        Console.WriteLine(sum);
    }
}