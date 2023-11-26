using System;
namespace LeetCodeProblems
{
	public class IsValidClass
	{
		public bool IsValid(string s)
		{
            string final = s;

            while (final.Contains("()") || final.Contains("[]") || final.Contains("{}"))
            {
                final = final.Replace("()", "").Replace("[]", "").Replace("{}", "");
            }

            return final == "";
        }
	}
}

