using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex6
{

	internal class Program
	{
	
		static void Main(string[] args)
		{
			Quilômetros conversão1;
			conversao1 = new Quilômetros();

			Console.WriteLine("\n---Exercício 6 da Lista 1---\n");
			
			Console.Write("Insira um valor em milhas marítimas: ");
			conversao1.setMilhaM(int.Parse(Console.ReadLine()));

			conversao1.calcular();

			Console.WriteLine("\n{0} milhas marítimas equivalem {1} quilômetros",
				conversao1.getMilhaM(), conversao1.getKm());	
		}	
	}
}
