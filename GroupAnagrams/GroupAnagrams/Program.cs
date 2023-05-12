using System;
using System.Collections.Generic;

namespace GroupAnagrams
{
	class Program
	{

		//un array dentro de otro     
		static IList<IList<string>> GroupAnagrams(string[] strs)
		{

			//creamos diccionario 
			var groups = new Dictionary<string, IList<string>>();

			//recorremos cada palabra del array
			foreach(string s in strs)
			{
				int[] hash = new int[26]; //array de los 26 numeros o caracteres del abecedario

				foreach(char c in s) //recorremos cada letra de la palabra 
				{
					hash[c - 'a']++; //vemos cuantas veces esta una letra y vamos aumentando
				}


				//convertir el array a string
				string key = string.Join(",", hash);

				//logica para poner cada palabra en su grupo correspondiente
				if (!groups.ContainsKey(key))
				{
					groups[key] = new List<string>();
				}
				
				groups[key].Add(s);
			}
			//retornar los valores del diccionario 
			return groups.Values.ToList();
		}


		//main
		static void Main(string[] args)
		{

			string[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" , "tae"};
			var result = Program.GroupAnagrams(strs);
			foreach (var group in result)
			{
				Console.WriteLine(string.Join(", ", group));
			}

		}
	}
}
