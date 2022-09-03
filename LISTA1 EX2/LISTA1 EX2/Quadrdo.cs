using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTA1_EX2
{
    internal class Quadrdo
    {
        private int aresta;
        private int resultado;

        public void setaresta(int n)
        {
            aresta = n;
        }

        public int getaresta()
        {
            return aresta;
        }

        public int getResultado()
        {
            return resultado;
        }
        public void somar()
        {
            resultado = aresta * aresta;
        }
    }

}
