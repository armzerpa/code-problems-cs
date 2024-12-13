using System;
using System.Collections.Generic;

namespace CodeProblems
{
    public class ContainDuplicate
    {
        public bool containDuplicate(int[] nums)
        {
            HashSet<int> uniqueElements = new HashSet<int>();

            for(int i = 0; i < nums.Length; i++)
            {
                if (uniqueElements.Contains(nums[i]))
                {
                    return true;
                }
                uniqueElements.Add(nums[i]);
            }
            return false;
        }
    }
}

