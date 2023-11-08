using System;
namespace LeetCodeProblems
{
	public class FinalValueAfterOperations
	{
		public int FinalValueAfterOperationsFunc(string[] operations)
		{
			int total = 0;

			foreach (string str in operations)
			{
				if (str == "X++" || str == "++X") total++;
				if (str == "X--" || str == "--X") total--;
			}

			return total;
		}
	}
}

