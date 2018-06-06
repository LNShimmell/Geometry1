using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geomitry
{
	class Sphere : Circle
	{

		public double Volume { get; set; }

		public override double GetArea()
		{
			Area= 4 * Math.PI * Radius * Radius;
			return Area;
		}

		public double GetVolume()
		{
			Volume = (4 / 3) * Math.PI * Math.Pow(Radius, 3);
			return Volume;
		}
		public Sphere()
		{

		}
		public Sphere(Double Radius):base(Radius)
		{

		}
	}
}

