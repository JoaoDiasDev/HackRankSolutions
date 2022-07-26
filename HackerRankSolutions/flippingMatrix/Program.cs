class Result
{
    /*
    * Complete the 'flippingMatrix' function below.
    *
    * The function is expected to return an INTEGER.
    * The function accepts 2D_INTEGER_ARRAY matrix as parameter.
    */
    public static int flippingMatrix(List<List<int>> matrix)
    {
        int n = matrix.Count / 2;
        var sum = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                sum += Math.Max(Math.Max(matrix[i][j], matrix[2 * n - 1 - i]
                [j]),
                Math.Max(matrix[i][2 * n - 1 - j], matrix[2 * n - 1 - i]
                [2 * n - 1 - j]));
            }
        }
        return sum;
    }
}