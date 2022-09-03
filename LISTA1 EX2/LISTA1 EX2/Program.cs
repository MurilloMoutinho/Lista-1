using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTA1_EX2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrdo soma1;
            soma1 = new Quadrdo();

            Console.Write("Digite a aresta do quadrado: ");
            soma1.setaresta(int.Parse(Console.ReadLine()));

            soma1.somar();

            Console.WriteLine("A área do quadrado é: {0}", soma1.getResultado());
        }
    }
}
