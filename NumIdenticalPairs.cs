using System;
namespace LeetCodeProblems
{
	public class NumIdenticalPairs
	{
		public int NumIdenticalPairsFunc(int[] nums)
		{

			int total = 0;

			for(int i = 0; i < nums.Length; i++)
			{
				for (int j = 0; j < nums.Length; j++)
				{
					if (i == j) continue;
					if (nums[i] == nums[j] && i < j) total++;
				}
			}

			return total;
		}
	}
}

