class Result
{

    /*
     * Complete the 'caesarCipher' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. STRING s
     *  2. INTEGER k
     */

    public static string caesarCipher(string s, int k)
    {
        var result = string.Empty;
        foreach (var c in s)
        {
            if (!((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z')))
            {
                result += c;
            }
            else
            {
                var isLower = (c >= 'a' && c <= 'z');

                var c1 = c.ToString().ToLower()[0];

                c1 += (char)(k % 26);

                if (c1 > 'z')
                {
                    c1 -= (char)26;
                }

                if (!isLower)
                {
                    c1 = c1.ToString().ToUpper()[0];
                }

                result += c1;
            }
        }
        return result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        string s = Console.ReadLine();

        int k = Convert.ToInt32(Console.ReadLine().Trim());

        string result = Result.caesarCipher(s, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
