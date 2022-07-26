class Result
{
    /*
    * Complete the 'palindromeIndex' function below.
    *
    * The function is expected to return an INTEGER.
    * The function accepts STRING s as parameter.
    */
    public static int palindromeIndex(string s)
    {
        int maxIndex = s.Length / 2;
        for (int i = 0; i < maxIndex; i++)
        {
            if (s[i] != s[s.Length - 1 - i])
            {
                if (s.Substring(i + 1, 2) == Reverse(s.Substring((s.Length -
                1 - i) - 1, 2)))
                {
                    return i;
                }
                else
                {
                    return (s.Length - 1 - i);
                }
            }
        }
        return -1;
    }
    static string Reverse(string str)
    {
        string reverse = "";
        int Length = 0;
        Length = str.Length - 1;
        while (Length >= 0)
        {
            reverse = reverse + str[Length];
            Length--;
        }
        return reverse;
    }
}
class Solution6
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        int q = Convert.ToInt32(Console.ReadLine().Trim());
        for (int qItr = 0; qItr < q; qItr++)
        {
            string s = Console.ReadLine();
            int result = Result.palindromeIndex(s);
            textWriter.WriteLine(result);
        }
        textWriter.Flush();
        textWriter.Close();
    }
}