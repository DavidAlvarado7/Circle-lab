using System;
namespace CIrcle_Objects
{
	public class Circle
	{
		public Circle(double radius)
		{
			Grow(_radius);

			_radius = radius;
			
		}

		
		private double _radius { get; set; }



		public double GetDiameterOfCircle()
		{
			double sum = 2 * _radius;
			return sum;
		}

		public double GetAreaOfCircle()
		{
			double sum = _radius +_radius * 3.14;
				return sum;

		}

		public double CalculateCircumference()
		{
			double radius = 2 * 3.14 * 2; 
			return radius;
		}

		public void Grow(double radius)

		{
			radius = 2 * _radius;

			
		}

		


	} 
}

