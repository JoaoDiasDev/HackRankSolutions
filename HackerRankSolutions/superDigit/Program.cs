class Result
{

    /*
     * Complete the 'superDigit' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. STRING n
     *  2. INTEGER k
     */

    public static int superDigit(string n, int k)
    {
        var sum = 0;
        string p = "";
        for (int i = 0; i < k; i++)
        {
            p += n;
        }
        sum = sumTotal(p, sum);
        return sum;
    }

    static int sumTotal(string n, int sum)
    {
        while (n.Length != 1)
        {
            sum = 0;
            for (int i = 0; i < n.Length; i++)
            {
                sum += Convert.ToInt32(n[i].ToString());
            }
            n = sum.ToString();
        }
        sum = Convert.ToInt32(n);
        return sum;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        string n = firstMultipleInput[0];

        int k = Convert.ToInt32(firstMultipleInput[1]);

        int result = Result.superDigit(n, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
