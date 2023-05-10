using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection.Metadata;

namespace TwoSum_2
{
	class Program
	{
		static bool Twosum(int[] nums, int limit)
		{
			if (nums == null || nums.Length <= 1 || limit < 1)
			{
				return false;
			}

			HashSet<int> set = new HashSet<int>();


			for (int i = 0; i < nums.Length; i++)
			{
				int n = nums[i];
				int complement = limit - nums[i]; //operacion 
				if (set.Contains(complement)) //ver si se contiene en el hash
				{
					return true;
				}
				set.Add(n); //agrega el numero por el cual se resto el limite

				if (i >= limit)
				{
					set.Remove(nums[i - limit]);  //eliminar el primer elemento si se pasa del limite que coloquemos
				}

			}
			return false;
		}

		static void Main(string[] args)
		{
			int[] nums = { 1, 0, 1, 1 };
			Console.WriteLine(Program.Twosum(nums, 2));
		}

	}
	

}
