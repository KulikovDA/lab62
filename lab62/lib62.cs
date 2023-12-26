namespace lib62
{
    public class lib
    {
        public static int[] CalculateColumnSums(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int[] columnSums = new int[cols];

            for (int j = 0; j < cols; j++)
            {
                for (int i = 0; i < rows; i++)
                {
                    columnSums[j] += matrix[i, j];
                }
            }

            return columnSums;
        }
    }
}