class Result
{

    /*
     * Complete the 'isBalanced' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string isBalanced(string s)
    {
        var stack = new Stack<char>();
        var dict = new Dictionary<char, char>();
        dict.Add(')', '(');
        dict.Add(']', '[');
        dict.Add('}', '{');
        var result = "YES";
        foreach (var c in s)
        {
            if (dict.ContainsKey(c))
            {
                if (stack.Count == 0)
                {
                    result = "NO";
                    break;
                }
                var top = stack.Pop();
                if (top != dict[c])
                {
                    result = "NO";
                    break;
                }
            }
            else
            {
                stack.Push(c);
            }
        }
        if (stack.Count > 0)
        {
            result = "NO";
        }
        return result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            string s = Console.ReadLine();

            string result = Result.isBalanced(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
