using System;

namespace RunningSumOf1dArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 2, 3, 4, -99999999 };
            int[] output = RunningSum(nums);
            foreach (int x in output)
            {
                Console.WriteLine(x);
            };
            Console.ReadLine();
        }
        public static int[] RunningSum(int[] nums)
        {
            if (nums.Length >= 1 && nums.Length <= 1000)
            {
                for (int i = 1; i < nums.Length; i++)
                {
                    nums[i] = nums[i] + nums[i - 1];
                    if (nums[i] <= -1000000 && nums[i] >= 1000000)
                        return null;
                }
                return nums;
            }
            else
                return null;
        }
    }
}
