using System;
using System.Collections.Generic;
using System.Linq;

namespace ThirdMaximumNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Given a non-empty array of integers, return the third maximum number in this array.
            //If it does not exist, return the maximum number.
            //The time complexity must be in O(n).

            int[] nums = new int[] {3, 2, 1};
            int output = ThirdMax(nums);
            Console.WriteLine(output);
            Console.ReadLine();
        }
        public static int ThirdMax(int[] nums)
        {
            if (nums.Length < 3)
                return nums.Max();
            
            List<int> myList = new List<int>(nums);
            myList.Sort((a, b) => b.CompareTo(a));
            nums = myList.ToArray();
            int firstMax = nums[0];
            int maxNum = nums[0];
            int count = 1;
            foreach (int x in nums)
            {
                if (x != maxNum)
                {
                    maxNum = x;
                    count++;
                    if (count == 3)
                        return maxNum;
                }

            }
            return firstMax;
        }
    }
}
