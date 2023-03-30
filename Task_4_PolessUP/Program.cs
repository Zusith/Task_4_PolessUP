
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ввод: ");
        int[] nums = new int[] { 2, 3, 1};
        Console.WriteLine("[" + string.Join(",", nums) + "]");
        Console.WriteLine("Вывод");
        Console.WriteLine(FindThirdMaxInGroupIfCan(nums));

        Console.ReadLine();
    }

    static int FindThirdMaxInGroupIfCan(int[] numbers)
    {
        int[] nums = new int[numbers.Length];
        numbers.CopyTo(nums, 0);

        if (nums.Length == 1) return nums[0];

        if (nums.Length == 2) return Math.Max(nums[0], nums[1]);

        return FindThirdMaxInGroup(nums);
    }

    static int FindThirdMaxInGroup(int[] nums)
    {
        Array.Sort(nums);
        for (int countdown = 2; countdown > 0; countdown--)
        {
            int n = nums.Length;
            Array.Resize(ref nums, n - 1);
        }
        return nums[nums.Length - 1];
    }

}