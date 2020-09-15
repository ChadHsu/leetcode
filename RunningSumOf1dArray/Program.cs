using System;

namespace RunningSumOf1dArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 2, 3, 4 };
            int[] output = RunningSum(nums);
            foreach (int x in output)
            {
                Console.WriteLine(x);
            };
            Console.ReadLine();
        }
        public static int[] RunningSum(int[] nums)
        {
            int[] output = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    output[i] += nums[j];
                }
            };

            return output;
        }
    }
}
