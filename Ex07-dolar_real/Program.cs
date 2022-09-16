using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex7
{

	internal class Program
	{
	
		static void Main(string[] args)
		{
			Reais conversao1;
			conversao1 = nem Reais();

			Console.WriteLine("\n---Exercício 7 da Lista 1---\n");
			
			Console.Write("Insira o valor do dólar em reais: R$ ");
			conversao1.setCot(int.Parse(Console.ReadLine()));

			Console.Write("Insira a quantia em dólares: ");
                        conversao1.setDol(int.Parse(Console.ReadLine()));

			conversao1.calcular();

			Console.WriteLine("\nValor em reasis: R${0}",
				conversao1.getReal().ToString("C"));
		}
	}
}
