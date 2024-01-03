class Result
{
    public static int SimpleArraySum(List<int> ar)
    {
        int sum = 0;
        foreach (var e in ar)
        {
            sum += e;
        }
        return sum;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int arCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

        int result = Result.SimpleArraySum(ar);

        Console.WriteLine(result);
    }
}
