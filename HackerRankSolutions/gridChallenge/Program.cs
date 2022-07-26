class Result
{

    /*
     * Complete the 'gridChallenge' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING_ARRAY grid as parameter.
     */

    public static string gridChallenge(List<string> grid)
    {
        var charList = new List<string>();
        for (int i = 0; i < grid.Count; i++)
        {
            var s = SortChar(grid[i]);
            charList.Add(s);
        }
        for (int i = 1; i < charList.Count; i++)
        {
            for (int j = 0; j < charList[0].Length; j++)
            {
                if (charList[i - 1].ElementAt(j) > charList[i].ElementAt(j))
                {
                    return "NO";
                }
            }
        }
        return "YES";
    }
    public static string SortChar(string s)
    {
        char[] ch = s.ToCharArray();
        Array.Sort(ch);
        return new string(ch);
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
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> grid = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string gridItem = Console.ReadLine();
                grid.Add(gridItem);
            }

            string result = Result.gridChallenge(grid);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
