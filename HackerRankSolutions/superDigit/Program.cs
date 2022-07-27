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
        long sum = 0;
        long temp = 0;
        for (int i = 0; i < n.Length; i++)
        {

            //temp += n[i] - 48; // Works too, but is a oddly formula
            temp += Convert.ToInt32(n[i].ToString());
            sum = temp * k;
        }

        while (sum > 9)
        {
            temp = 0;
            n = "" + sum;

            for (int i = 0; i < n.Length; i++)
            {
                var digit = sum % 10;
                temp += (int)digit;
                sum /= 10;
            }
            sum = temp;
        }

        return (int)sum;
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
