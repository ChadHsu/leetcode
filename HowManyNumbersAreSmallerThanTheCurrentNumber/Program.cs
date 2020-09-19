using System;
using System.Collections.Generic;

namespace HowManyNumbersAreSmallerThanTheCurrentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Given the array nums, for each nums[i] find out how many numbers in the array are smaller than it. That is, for each nums[i] you have to count the number of valid j's such that j != i and nums[j] < nums[i].
            //Return the answer in an array.
            int[] nums = new int[] { 8, 1, 2, 2, 3 };
            int[] output = SmallerNumbersThanCurrent(nums);
            foreach (int x in output)
            {
                Console.Write(x + " ");
            };
            Console.ReadLine();
        }
        public static int[] SmallerNumbersThanCurrent(int[] nums)
        {
            int[] output = new int[nums.Length];
            output.Initialize();
            if (nums.Length >= 2 && nums.Length <= 500)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] < 0 || nums[i] > 100)
                        return null;
                    for (int j = 0; j < nums.Length; j++)
                    {
                        if (i != j && nums[i] > nums[j])
                            output[i]++;
                    }
                }
            }
            return output;
        }
    }
}
