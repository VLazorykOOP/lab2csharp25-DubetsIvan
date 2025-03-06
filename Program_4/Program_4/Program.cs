using System;

class Program_4
{
    static void Main4(string[] args)
    {
        Console.WriteLine("Введiть кiлькiсть рядкiв: ");
        int size = int.Parse(Console.ReadLine());

        int[][] st_arr = new int[size][];
        int[] lastOddInRows = new int[size];
        Array.Fill(lastOddInRows, -1);

        Random rand = new Random();

        for (int i = 0; i < size; i++)
        {
            Console.WriteLine($"Ввeдiть кiлькiсть елементiв в рядку {i + 1}");
            int n = int.Parse(Console.ReadLine());
            st_arr[i] = new int[n];

            for (int j = 0; j < n; j++)
            {
                st_arr[i][j] = rand.Next(0, 100);
            }
        }

        Console.WriteLine("Масив: ");
        foreach (var row in st_arr)
        {
            Console.WriteLine(string.Join(" ", row));
        }

        Console.WriteLine("Останнi непарнi елементи в рядках та їх iндекси: ");
        for (int i = 0; i < st_arr.Length; i++)
        {
            for (int j = st_arr[i].Length - 1; j >= 0; j--)
            {
                if (st_arr[i][j] % 2 != 0)
                {
                    lastOddInRows[i] = st_arr[i][j];
                    Console.WriteLine($"Рядок {i + 1}: елемент {st_arr[i][j]}, iндекс {j}");
                    break;
                }
            }
        }

        Console.WriteLine("Останнi непарнi елементи в рядках:");
        for (int i = 0; i < lastOddInRows.Length; i++)
        {
            Console.WriteLine($"Рядок {i + 1}: {(lastOddInRows[i] != -1 ? lastOddInRows[i].ToString() : "Немає непарних")}");
        }

        int maxColumns = 0;
        foreach (var row in st_arr)
        {
            if (row.Length > maxColumns)
            {
                maxColumns = row.Length;
            }
        }

        int[] lastOddInColumns = new int[maxColumns];
        Array.Fill(lastOddInColumns, -1);

        for (int col = 0; col < maxColumns; col++)
        {
            for (int row = st_arr.Length - 1; row >= 0; row--)
            {
                if (col < st_arr[row].Length && st_arr[row][col] % 2 != 0)
                {
                    lastOddInColumns[col] = st_arr[row][col];
                    break;
                }
            }
        }

        Console.WriteLine("Останнi непарнi елементи в стовпцях: ");
        for (int i = 0; i < lastOddInColumns.Length; i++)
        {
            Console.WriteLine($"Стовпець {i + 1}: {(lastOddInColumns[i] != -1 ? lastOddInColumns[i].ToString() : "Немає непарних")}");
        }
    }
}
