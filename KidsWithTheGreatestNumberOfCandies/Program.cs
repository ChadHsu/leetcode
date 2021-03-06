﻿using System;
using System.Collections.Generic;

namespace KidsWithTheGreatestNumberOfCandies
{
    class Program
    {
        static void Main(string[] args)
        {
            //Given the array candies and the integer extraCandies, where candies[i] represents the number of candies that the ith kid has.
            //For each kid check if there is a way to distribute extraCandies among the kids such that he or she can have the greatest number of candies among them. Notice that multiple kids can have the greatest number of candies.

            //Input: candies = [2,3,5,1,3], extraCandies = 3
            //Output:[true,true,true,false,true] 
            //Explanation:
            //Kid 1 has 2 candies and if he or she receives all extra candies(3) will have 5 candies-- - the greatest number of candies among the kids.
            //Kid 2 has 3 candies and if he or she receives at least 2 extra candies will have the greatest number of candies among the kids. 
            //Kid 3 has 5 candies and this is already the greatest number of candies among the kids.
            //Kid 4 has 1 candy and even if he or she receives all extra candies will only have 4 candies.
            //Kid 5 has 3 candies and if he or she receives at least 2 extra candies will have the greatest number of candies among the kids. 
            int[] candies = new int[] { 2, 3, 5, 1, 3 };
            int extraCandies = 3;
            IList<bool> output = KidsWithCandies(candies, extraCandies);
            foreach (bool x in output)
            {
                Console.Write(x + " ");
            };
            Console.ReadLine();
        }
        public static IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            IList<bool> output = new List<bool>();
            int maxCandies = 0;
            foreach (int candy in candies) 
            {
                if (candy > maxCandies)
                    maxCandies = candy;
            }

            foreach (int candy in candies)
            {
                bool output1 = (candy + extraCandies >= maxCandies);
                output.Add(output1);
            }

            return output;
        }
    }
}
