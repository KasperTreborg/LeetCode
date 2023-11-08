using System;
namespace LeetCodeProblems
{
	public class BuildArray
	{
		public int[] BuildArrayFunc(int[] nums)
		{
			int[] ans = new int[nums.Length];

			for (int i = 0; i < nums.Length; i++)
			{
				if (0 <= i && i < nums.Length) ans[i] = nums[nums[i]];
			}

			return ans;
		}
	}
}