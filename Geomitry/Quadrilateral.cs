using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geomitry
{
	class Quadrilateral
	{
		public double side1 { get; set; }
		public double side2 { get; set; }
		public double side3 { get; set; }
		public double side4 { get; set; }
		public double Perimeter { get; set; }


		public double getPerimeter()
		{
			Perimeter = side1 + side2 + side3 + side4;
			return Perimeter;
		}

		public virtual double? GetArea()
		{
			
			return null;

		}

		public Quadrilateral()
		{

		}
		public Quadrilateral(double side1, double side2, double side3, double side4)
		{
			this.side1 = side1; this.side2 = side2; this.side3 = side3; this.side4 = side4;
		}
	}
}
