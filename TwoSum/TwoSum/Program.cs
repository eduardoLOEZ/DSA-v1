using System;
using System.Collections.Generic;

namespace TwoSum
{
	class Program
	{

		static int[] Twosum(int[] nums, int target)
		{
			Dictionary<int, int> set = new Dictionary<int, int>();

			for(int i = 0; i< nums.Length; i++)
			{
				int diff = target - nums[i];

				if (set.ContainsKey(diff))
				{
					return new int[] { set[diff], i};
				}
				set.Add(nums[i], i);
			}

			return new int[] { };
		}

		static void Main(string[] args)
		{
			int[] nums = { 2, 7, 11, 15 };
			int[] result = Program.Twosum(nums, 18);
			Console.WriteLine(result[0]+ " "+ result[1]);
		}
	}
}
