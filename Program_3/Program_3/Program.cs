using System;
using System.Drawing;

class Program_3
{
    static void Main3(string[] args)
    {
        Console.WriteLine("Введiть розмiр масиву (рядки i стовпцi): ");
        int size_r = int.Parse(Console.ReadLine());
        int size_c = int.Parse(Console.ReadLine());
        Random rand = new Random();
        int[,] arr = new int[size_r, size_c];
        for (int i = 0; i < size_r; i++)
        {
            for (int j = 0; j < size_c; j++)
            {
                arr[i, j] = rand.Next(1, 101);
            }
        }
        Console.WriteLine("Матриця: ");
        for(int i = 0;i < size_r; i++)
        {
            for(int j  = 0; j < size_c; j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine("");
        }
        Console.WriteLine("Матриця пiсля манiпуляцiй: ");
        if((size_r % 2) == 0)
        {
            for(int i = 0; i < size_r; i += 2)
            {
                for(int j =0; j < size_c; j++)
                {
                    int temp = arr[i, j];
                    arr[i, j] = arr[i + 1, j];
                    arr[i + 1, j] = temp;
                }
            }
            for (int i = 0; i < size_r; i++)
            {
                for (int j = 0; j < size_c; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine("");
            }
        }
        else
        {
            Console.WriteLine("Матриця має не парну кiлькiсть рядкiв тому залишається незмiнною");
        }
    }
}