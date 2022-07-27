class Result
{

    /*
     * Complete the 'truckTour' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY petrolpumps as parameter.
     */

    public static int truckTour(List<List<int>> petrolpumps)
    {
        int start = 0;
        int end = 1;
        var curr_petrol = petrolpumps[start][0] - petrolpumps[start][1];

        while (end != start || curr_petrol < 0)
        {
            while (curr_petrol < 0 && start != end)
            {
                curr_petrol -= petrolpumps[start][0] - petrolpumps[start][1];
                start = (start + 1) % petrolpumps.Count;

                if (start == 0)
                {
                    return -1;
                }
            }
            curr_petrol += petrolpumps[end][0] - petrolpumps[end][1];

            end = (end + 1) % petrolpumps.Count;
        }
        return start;
    }
}


class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> petrolpumps = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            petrolpumps.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(petrolpumpsTemp => Convert.ToInt32(petrolpumpsTemp)).ToList());
        }

        int result = Result.truckTour(petrolpumps);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
