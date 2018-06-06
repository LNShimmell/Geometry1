using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geomitry
{
	class Cylinder: Circle
	{
		public double Height { get; set; }
		public double Volume { get; set; }

		public Cylinder()
		{

		}
		public Cylinder(double Radius, double Height):base(Radius)
		{
			this.Height = Height;

		}
		

		public double GetVolume()
		{
			Volume = Height * Math.Pow(Radius, 2) * Math.PI;
			return Volume;
		}
		public override double GetArea()
		{
			Area= 2*(Radius * Radius * Math.PI) + (2*Math.PI * Radius * Height);
			return Area;
		}
		
	}
}
