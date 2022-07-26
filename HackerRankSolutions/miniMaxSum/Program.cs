class Result
{

    /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<long> arr)
    {
        var sumExceptZeroIndex = Convert.ToInt64(arr[1] + arr[2] + arr[3] + arr[4]);
        var sumExceptFirstIndex = Convert.ToInt64(arr[0] + arr[2] + arr[3] + arr[4]);
        var sumExceptSecondIndex = Convert.ToInt64(arr[0] + arr[1] + arr[3] + arr[4]);
        var sumExceptThirdIndex = Convert.ToInt64(arr[0] + arr[1] + arr[2] + arr[4]);
        var sumExceptFourthIndex = Convert.ToInt64(arr[0] + arr[1] + arr[2] + arr[3]);

        var ListInteger = new List<long>();
        ListInteger.Add(sumExceptZeroIndex);
        ListInteger.Add(sumExceptFirstIndex);
        ListInteger.Add(sumExceptSecondIndex);
        ListInteger.Add(sumExceptThirdIndex);
        ListInteger.Add(sumExceptFourthIndex);

        var min = ListInteger.Min();
        var max = ListInteger.Max();

        Console.WriteLine($"{min} {max}");
        Console.ReadLine();
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        List<long> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt64(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}
