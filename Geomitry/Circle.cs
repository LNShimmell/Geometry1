using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geomitry
{
	class Circle
	{
		public double Radius { get; set; }
		public double Area { get; set; }


		public virtual double GetArea (){
			Area = Math.Pow(Radius,2) * Math.PI;
			return Area;
		}
		public Circle(double Radius)
		{
			this.Radius = Radius;
		}
		public Circle()
		{

		}
	}
}
