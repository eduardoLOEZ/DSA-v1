// See https://aka.ms/new-console-template for more information
using System;


public class ConsoleApp1
{
	public static void Main(string[] args)
	{
		bool continuar = true;

		while (continuar)
		{
			Console.WriteLine("escribe un numero: ");
			int numero = Convert.ToInt32(Console.ReadLine());

			int result = numero * numero;
			Console.WriteLine("el cuadrado del numero es: "+result);

			Console.WriteLine("deseas ingresar otro numero ? s/n");
			string respuesta = Console.ReadLine().ToLower();
			
			if(respuesta == "n")
			{
				continuar = false;

			}else if(respuesta== "s")
			{
				continuar = true;
			}
			else
			{
				Console.WriteLine("esa respuesta no es valida");
				
			}

		}
		Console.WriteLine("saliendo del programa...");
		Console.ReadLine();
		


	}
}


