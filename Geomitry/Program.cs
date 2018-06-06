using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geomitry
{
	class Program
	{
		static void Main(string[] args)
		{
			Circle circle1 = new Circle(3);
			circle1.GetArea();

			Cylinder cylinder1 = new Cylinder(3, 10);
			cylinder1.GetArea(); cylinder1.GetVolume();

			Sphere sphere1 = new Sphere(3);
			sphere1.GetVolume();
			sphere1.GetArea();

			Square square1 = new Square(5);
			square1.getPerimeter();
			square1.GetArea();
			
			Rectangle rectangle1 = new Rectangle(4, 5);
			rectangle1.getPerimeter();
			rectangle1.GetArea();


		}
	}
}
