using ClassLibrary1;

class Program
{
    static void Main()
    {
        Random random = new Random();

        Console.Write("Введите количество строк: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Введите количество столбцов: ");
        int m = int.Parse(Console.ReadLine());

        int[,] array = new int[n, m];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                array[i, j] = random.Next(1, 10);
            }
        }

        Console.WriteLine("генерированный массив:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }

        int[] minElem = Class1.CalculatMinElement(array);

        Console.WriteLine("Минимальный элемент из каждого столбца:");
        foreach (var element in minElem)
        {
            Console.Write(element + " ");
        }
    }
}