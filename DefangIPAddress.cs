using System;
namespace LeetCodeProblems
{
	public class DefangIPAddress
	{
		public string DefangIPaddr(string address)
		{
			string defanged = "";

			for (int i = 0; i < address.Length; i++)
			{
				if (address[i] == '.') defanged += "[.]";
				else defanged += address[i];
			}

			return defanged;
		}
	}
}
