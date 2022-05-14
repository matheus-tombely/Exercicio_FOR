using System;

public class Program
{
	public static void Main()
	{
		int[] numeros = new int[4];
		int[] numeros2 = new int[4];
		int[] result = new int[4];


		Console.WriteLine("DIGITE OS NUMEROS DO VETOR 1: ");
		for (int i = 0; i < numeros.Length; i++)

		{
			Console.WriteLine("POSIÇÃO " + (i + 1) + ":");
			numeros[i] = int.Parse(Console.ReadLine());
		}
		Console.WriteLine("\n=================================\n");
		Console.WriteLine("DIGITE OS NUMEROS DO VETOR 2: ");

		for (int i = 0; i < numeros2.Length; i++)
		{
			Console.WriteLine("POSIÇÃO " + (i + 1) + ":");
			numeros2[i] = int.Parse(Console.ReadLine());
		}

		Console.WriteLine("UNIÃO DOS VETORES: \n");

		int[] numeros3 = new int[4];
		for (int i = 0; i < numeros3.Length; i++)
		{
			if (i % 2 == 0)
			{
				numeros3[i] = numeros[i];
			}
			else if (i % 2 == 1)
			{
				numeros3[i] = numeros2[i];
			}
		}
		for (int i = 0; i < numeros3.Length; i++)
		{
			Console.WriteLine("INDICE " + (i + 1) + ":" + numeros3[i]);
		}




	}

}
