using System;

namespace NumberOfGoodPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Given an array of integers nums.
            //A pair(i, j) is called good if nums[i] == nums[j] and i < j.
            //Return the number of good pairs.
            int[] nums = new int[] { 1, 2, 3, 1, 1, 3 };
            int output = NumIdenticalPairs(nums);
            Console.Write(output);
            Console.ReadLine();
        }
        public static int NumIdenticalPairs(int[] nums)
        {
            int output = 0;

            for(int i = 0; i < nums.Length - 1; i++)
            {
                for(int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                        output++;
                }
            }

            return output;
        }
    }
}
