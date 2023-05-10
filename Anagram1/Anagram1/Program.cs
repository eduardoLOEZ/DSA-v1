using System;
using System.Collections.Generic;

namespace Anagram1
{
	class Program
	{
		static bool Anagram(string s, string t)
		{
			if(s.Length != t.Length)
			{
				return false;
			}

			Dictionary<char, int> freq = new Dictionary<char, int>();


			foreach(char c in s)
			{
				if (freq.ContainsKey(c))
				{
					freq[c]++; //si ya existe, aumenta
				}
				else
				{
					freq.Add(c, 1); //agrega la letra con su valor 1
				}


			}

			//segundo string
			foreach(char c in t)
			{
				if (!freq.ContainsKey(c))
				{
					return false;
				}
				else
				{
					freq[c]--;
				}
				
			}

			//vemos los vaores finales del diccionario y tienen que encajar en 0 
			foreach(var counts in freq.Values)
			{
				if(counts== 0)
				{
					return true;
				}
			}
			return false;
		}



		static void Main(string[] args)
		{
			Console.WriteLine(Program.Anagram("anagram", "nagaram")); // => true
		}
	}
}
