using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex6
{

	internal class Quilômetros
	{
		private double milhaM;
		private double km;
		
		public void setMilhaM(double n)
		{
			milhaM = n ;
		}	

		public double getMilhaM()
                {
                        return milhaM;
                }

		public double getKm()
		{
			return km;
		}

		public void calcular()
		{
			km = milham * 1.852;
		}
	}
}
