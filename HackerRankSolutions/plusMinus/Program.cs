class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        var greaterThanZero = (decimal)arr.Count(x => x > 0m) / arr.Count;
        var lesserThanZero = (decimal)arr.Count(x => x < 0m) / arr.Count;
        var zeros = (decimal)arr.Count(x => x == 0m) / arr.Count;

        Console.WriteLine(greaterThanZero.ToString("F6"));
        Console.WriteLine(lesserThanZero.ToString("F6"));
        Console.WriteLine(zeros.ToString("F6"));
        Console.ReadLine();
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
