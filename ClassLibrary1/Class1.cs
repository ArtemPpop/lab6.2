namespace ClassLibrary1
{
    public class Class1
    {
        public static int[] CalculatMinElement(int[,] matrx)
        {
            int lines = matrx.GetLength(0);
            int cols = matrx.GetLength(1);
            int[] minElem = new int[cols];

            for (int j = 0; j < cols; j++)
            {
                int min = matrx[0, j];
                for (int i = 1; i < lines; i++)
                {
                    if (matrx[i, j] < min)
                    {
                        min = matrx[i, j];
                    }
                }
                minElem[j] = min;
            }

            return minElem;
        }
    }
}




