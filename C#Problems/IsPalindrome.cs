using System;
using System.Collections.Generic;
namespace LeetCodeProblems
{
	public class IsPalindrome
	{

        public bool Palindrome(int x)
		{

			String test = x.ToString();
			char[] charry = test.ToCharArray();

			Array.Reverse(charry);

			if (test == new string(charry)) return true;


			return false;
		}
	}
}


