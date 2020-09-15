using System;
using System.Diagnostics.CodeAnalysis;

namespace ShuffleTheArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Given the array nums consisting of 2n elements in the form [x1,x2,...,xn,y1,y2,...,yn].
            //Return the array in the form[x1, y1, x2, y2, ..., xn, yn].
            int[] nums = new int[] { 2, 5, 1, 3, 4, 7 };
            int n = 3;
            int[] output = Shuffle(nums, n);
            foreach (int x in output)
            {
                Console.Write(x + " ");
            };
            Console.ReadLine();
        }
        public static int[] Shuffle(int[] nums, int n)
        {
            if (n >= 1 && n <= 500 && nums.Length == 2 * n)
            {
                int[] output = new int[nums.Length];
                int j = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (i % 2 == 0)
                        output[i] = nums[i - j];
                    else
                    {
                        output[i] = nums[n + j];
                        j++;
                    }
                }
                return output;
            }
            else
                return null;
        }
    }
}
