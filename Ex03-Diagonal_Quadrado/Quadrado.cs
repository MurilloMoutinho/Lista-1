using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex3
{

	internal class Quadrado
	{
		private double diag;
		private double area;

		public void setDiag(int n)
		{
			diag = n ;
		}	

		public double getDiag()
		{
			return diag;
		}

		public double getArea()
		{
			return area;
		}

		public void calcular()
		{
			area = Math.Pow(diag / Math.Sqrt(2), 2);
		}
	}
}
