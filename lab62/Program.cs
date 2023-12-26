using lib62;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество строк: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Введите количество столбцов: ");
        int cols = int.Parse(Console.ReadLine());

        int[,] matrix = new int[rows, cols];

        Console.WriteLine("Введите элементы матрицы:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write("Элемент [{0},{1}] = ", i, j);
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int[] columnSums = lib.CalculateColumnSums(matrix);

        Console.WriteLine("Результат:");
        foreach (int sum in columnSums)
        {
            Console.Write(sum + " ");
        }
    }
}