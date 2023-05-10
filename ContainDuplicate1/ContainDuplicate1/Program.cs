using System;
using System.Collections.Generic;

namespace ContainDuplicate1
{
	class Program
	{

		static bool Duplicate(int[] nums)
		{
			HashSet<int> set = new HashSet<int>();

			foreach (int x in nums)
			{
				if (set.Contains(x)) return true;
				set.Add(x);
			}
			return false;
		}

	



		static void Main(string[] args)
		{
			int[] nums = { 1, 2, 3, 4, 5 };
			Console.WriteLine(Duplicate(nums));
		}
	}
}
