class Result
{

    /*
     * Complete the 'minimumBribes' function below.
     *
     * The function accepts INTEGER_ARRAY q as parameter.
     */

    public static void minimumBribes(List<int> q)
    {
        var arrayQ = q.ToArray();
        var total = 0;
        var chaos = false;
        for (int i = arrayQ.Length - 1; i >= 0; i--)
        {
            int pos = arrayQ[i] - 1 - i;
            if (pos == 1)
            {
                total += 1;
                Swap(ref arrayQ[i], ref arrayQ[i + 1]);
                i += 1;
            }
            else if (pos == 2)
            {
                total += 2;
                Swap(ref arrayQ[i], ref arrayQ[i + 2]);
                Swap(ref arrayQ[i], ref arrayQ[i + 1]);
                i += 2;
            }
            else if (pos > 2)
            {
                chaos = true;
                break;
            }
        }

        if (chaos)
        {
            Console.WriteLine("Too chaotic");
        }
        else
        {
            Console.WriteLine(total);
        }
    }
    public static void Swap(ref int left, ref int right)
    {
        var temp = left;
        left = right;
        right = temp;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> q = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(qTemp => Convert.ToInt32(qTemp)).ToList();

            Result.minimumBribes(q);
        }
    }
}
