using System;
using System.Collections.Generic;

namespace Anagram2
{
	class Program
	{

		static bool Anagram(string s, string t)
		{
			if (s.Length != t.Length) return false;

			int[] freq = new int[26]; // array para guardar frecuencia de cada letra

			// recorre s para incrementar la frecuencia de cada letra
			foreach (char c in s)
			{
				freq[c - 'a']++;
			}


			// recorre t para decrementar la frecuencia de cada letra
			foreach (char c in t)
			{
				freq[c - 'a']--;

				if (freq[c - 'a'] < 0) return false;   // si la frecuencia es negativa, no es anagrama

			}

			return true; // si llega aquí, es anagrama
		}



		static void Main(string[] args)
		{
			Console.WriteLine(Program.Anagram("hola", "aloha"));
		}
	}
}
