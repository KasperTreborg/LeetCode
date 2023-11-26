using System;
namespace LeetCodeProblems
{
	public class JewelsAndStones
	{
		public int NumJewelsInStones(string jewels, string stones)
		{
			int output = 0;

			for (int i = 0; i < jewels.Length; i++)
			{
                output += stones.Count(t => t == jewels[i]);
            }

			return output;
		}
	}
}

