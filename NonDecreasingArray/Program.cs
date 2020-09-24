using System;
using System.Globalization;
using System.Threading;

namespace NonDecreasingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Given an array nums with n integers, your task is to check if it could become non-decreasing by modifying at most 1 element.
            //We define an array is non - decreasing if nums[i] <= nums[i + 1] holds for every i (0 - based) such that(0 <= i <= n - 2).

            //Constraints:
            //1 <= n <= 10 ^ 4
            //- 10 ^ 5 <= nums[i] <= 10 ^ 5
            int[] nums = new int[] { 4, 2, 3 };
            bool output = CheckPossibility(nums);
            Console.Write(output);
            Console.ReadLine();
        }
        public static bool CheckPossibility(int[] nums)
        {
            if (nums.Length >= 1 && nums.Length <= 10000)
            {
                bool isChange = false;
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    if (nums[i] > nums[i + 1])
                    {
                        if (isChange)
                            return false;
                        if (i > 0 && nums[i + 1] >= nums[i - 1])
                        {
                            nums[i] = nums[i + 1];
                            isChange = true;
                        }
                        if (i > 0 && nums[i + 1] < nums[i - 1])
                        {
                            nums[i + 1] = nums[i];
                            isChange = true;
                        }
                        if (i == 0)
                        {
                            nums[i] = nums[i + 1];
                            isChange = true;
                        }
                    }
                }
                return true;
            }
            else
                return false;
        }
    }
}
