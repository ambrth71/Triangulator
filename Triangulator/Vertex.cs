using System.Windows;

namespace Triangulator
{
	struct Vertex
	{
		public readonly Point Position;
		public readonly int Index;

		public Vertex(Point position, int index)
		{
			Position = position;
			Index = index;
		}

		public override bool Equals(object obj)
		{
			if (!(obj is Vertex))
				return false;
			return Equals((Vertex)obj);
		}

		public bool Equals(Vertex obj)
		{
			return obj.Position.Equals(Position) && obj.Index == Index;
		}

		public override int GetHashCode()
		{
			unchecked
			{
				return (Position.GetHashCode() * 397) ^ Index;
			}
		}

		public override string ToString()
		{
			return string.Format("{0} ({1})", Position, Index);
		}
	}
}