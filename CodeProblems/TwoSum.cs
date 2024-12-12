using System;
using System.Collections.Generic;

namespace CodeProblems
{
    public class TwoSum : SolutionInterface
    {
        public int[] solution(int[] nums, int target)
        {
            IDictionary<int, int> hashmap = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int residual = target - nums[i];

                if (hashmap.ContainsKey(residual))
                    return new int[] { hashmap[residual], i };

                hashmap.TryAdd(nums[i], i);
            }
            return new int[] { };
        }
    }
}

