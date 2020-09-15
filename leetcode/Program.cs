using System;

namespace leetcode
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
    }
}
