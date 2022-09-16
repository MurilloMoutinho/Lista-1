using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex8
{

	internal class Maior
	{
		private double v1;
		private double v2;
		private double maior;

		public void setV1(double n)
		{
			v1 = n ;
		}	

		public void setV2(double n)
                {
                        v2 = n ;
                }

		public double getV1()
		{
			return v1;
		}

		public double getV2()
		{
			return v2;
		}

		public double getMaior()
                {
                        return maior;
                }

		public void calcular()
		{
			if (v1 > v2)
			{
				maior = v1;
			}
			else
			{
				maior = v2;
			}
		}
	}
}
