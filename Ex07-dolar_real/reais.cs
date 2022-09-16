using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex7
{

	internal class Triângulo
	{
		private double cotacao;
		private double dolar;
		private double real;

		public void setCot(double n)
		{
			cotacao = n ;
		}	

		public void setDol(double n)
                {
                        dolar = n ;
                }

		public double getCot()
		{
			return cotacao;
		}

		public double getDol()
		{
			return dolar;
		}

		public double getReal()
                {
                        return real;
                }

		public void calcular()
		{
			real = dolar * cotação;
		}
	}
}
