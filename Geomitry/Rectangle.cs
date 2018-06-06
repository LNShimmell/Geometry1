using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geomitry
{
	class Rectangle :Quadrilateral
	{
		public double Area { get; set; }

		public Rectangle(double length, double width)
		{
			this.side1 = length;
			this.side3 = length;
			this.side2 = width;
			this.side4 = width;
		}
		public override double? GetArea()
		{
			Area = this.side1 * this.side2;
			return Area;
		}
		public Rectangle()
		{

		}

	}
}
