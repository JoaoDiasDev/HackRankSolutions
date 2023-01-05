class Solution
{
    public int CalPoints(string[] ops)
    {
        List<int> result = new List<int>();
        foreach (var item in ops)
        {
            var isNumber = (int.TryParse(item, out int res));
            if (isNumber)
            {
                if (res >= 1 && res <= 1000)
                {
                    result.Add(res);
                }
            }
            else if (item == "C")
            {
                result.RemoveAt(result.IndexOf(result.Last()));
            }
            else if (item == "D")
            {
                var lastNumber = result.LastOrDefault();
                result.Add(lastNumber * 2);
            }
            else if (item == "+")
            {
                var lastNumber = result.LastOrDefault();
                var lastIndexMinusOne = (result.IndexOf(result.Last()) - 1);
                var numberOneIndexBeforeLast = result.ElementAt(lastIndexMinusOne);
                result.Add(lastNumber + numberOneIndexBeforeLast);
            }
        }
        return result.Sum();
    }

}

class CalPoints
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();
        char[] space = new char[] { ' ' };

        string[] ops = Console.ReadLine().Split(space);

        int output = solution.CalPoints(ops);

        Console.Write(output.ToString());
        Console.ReadLine();
    }
}