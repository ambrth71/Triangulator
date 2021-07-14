using System;
using System.Windows;

namespace Triangulator
{
	struct LineSegment
	{
		public static readonly Point INVALIDPOINT = new Point(Double.MaxValue, Double.MaxValue);
		public Vertex A;
		public Vertex B;

		public LineSegment(Vertex a, Vertex b)
		{
			A = a;
			B = b;
		}

		public bool IntersectsWithRay(Point origin, Vector direction, out double value)
		{
			double largestDistance = Math.Max(A.Position.X - origin.X, B.Position.X - origin.X) * 2.0;
			LineSegment raySegment = new LineSegment(new Vertex(origin, 0), new Vertex(origin + (direction * largestDistance), 0));

			Point intersection = FindIntersection(this, raySegment);
			value = 0.0;

			if (intersection != INVALIDPOINT)
			{
				value = (intersection - origin).Length;
				return true;
			}

			return false;
		}

		public static Point FindIntersection(LineSegment a, LineSegment b)
		{
			double x1 = a.A.Position.X;
			double y1 = a.A.Position.Y;
			double x2 = a.B.Position.X;
			double y2 = a.B.Position.Y;
			double x3 = b.A.Position.X;
			double y3 = b.A.Position.Y;
			double x4 = b.B.Position.X;
			double y4 = b.B.Position.Y;

			double denom = (y4 - y3) * (x2 - x1) - (x4 - x3) * (y2 - y1);

			double uaNum = (x4 - x3) * (y1 - y3) - (y4 - y3) * (x1 - x3);
			double ubNum = (x2 - x1) * (y1 - y3) - (y2 - y1) * (x1 - x3);

			double ua = uaNum / denom;
			double ub = ubNum / denom;
			;
			if (Math.Min(Math.Max(ua, 0), 1) != ua || Math.Min(Math.Max(ub, 0), 1) != ub)
				return INVALIDPOINT;

			return a.A.Position + (a.B.Position - a.A.Position) * ua;
		}
	}
}
