using System;
namespace LeetCodeProblems
{
	public class LongestCommonPrefix
	{
		public string LongestCommonPrefixFunction(string[] strs)
		{
			if (strs.Length == 0) return "";

			string prefix = strs[0];
			for (int i = 1; i < strs.Length; i++)
			{
				while (strs[i].IndexOf(prefix) != 0)
				{
					prefix = prefix[..^1];
					if (string.IsNullOrEmpty(prefix)) return "";
				}
			}

			Console.WriteLine(prefix);
			return prefix;

		}
	}
}