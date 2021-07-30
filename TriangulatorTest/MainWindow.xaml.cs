using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace TriangulatorTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
	{
		private int Example;
		public MainWindow()
		{
			Example = 0;
			InitializeComponent();
			CreateGeometry();
		}

		private Point[] OriginalExample()
        {
			// create or load in some vertices
			Point[] sourceVertices = new Point[]
			{
				new Point(-100, -100),
				new Point(0, -200),
				new Point(100, -100),
				new Point(100, 100),
				new Point(0, 200),
				new Point(-100, 100)
			};

			// create our hole vertices
			Point[] holeVertices = new Point[]
			{
				new Point(-40, -40),
				new Point(-40, 40),
				new Point(0, 20),
				new Point(40, 40),
				new Point(40, -40),
				new Point(0, -20),
			};

			// cut the hole out of the source vertices
			sourceVertices = Triangulator.Triangulator.CutHoleInShape(sourceVertices, holeVertices);

			// move the hole up a little bit and cut it out again
			for (int i = 0; i < holeVertices.Length; i++)
				holeVertices[i].Y += 90f;
			sourceVertices = Triangulator.Triangulator.CutHoleInShape(sourceVertices, holeVertices);

			// move it down a bit and cut it out again
			for (int i = 0; i < holeVertices.Length; i++)
				holeVertices[i].Y -= 180f;
			sourceVertices = Triangulator.Triangulator.CutHoleInShape(sourceVertices, holeVertices);

			return sourceVertices;
		}

		private Point[] AlignedHolesOnRight()
        {
			Point[] sourceVertices = new Point[]
			{
			   new Point(0, 0),
			   new Point(210, 0),
			   new Point(210, 150),
			   new Point(0, 150)
			};
			Point[] holeVertices = new Point[]
			{
			   new Point(150, 100),
			   new Point(175, 100),
			   new Point(175, 125),
			   new Point(150, 125)
			};
			sourceVertices = Triangulator.Triangulator.CutHoleInShape(sourceVertices, holeVertices);
			holeVertices = new Point[]
			{
			   new Point(150, 25),
			   new Point(175, 25),
			   new Point(175, 75),
			   new Point(125, 75),
			   new Point(125, 140),
			   new Point(100, 135),
			   new Point(100, 50),
			   new Point(150, 50)
			};
			sourceVertices = Triangulator.Triangulator.CutHoleInShape(sourceVertices, holeVertices);
			return sourceVertices;
		}

		private Point[] PolygonPointOnRay()
        {
			Point[] sourceVertices = new Point[]
			{
			   new Point(0, 0),
			   new Point(210, 0),
			   new Point(210, 150),
			   new Point(0, 150)
			};
			Point[] holeVertices = new Point[]
			{
			   new Point(140, 90),
			   new Point(175, 105),
			   new Point(160, 140),
			};
			sourceVertices = Triangulator.Triangulator.CutHoleInShape(sourceVertices, holeVertices);
			holeVertices = new Point[]
			{
			   new Point(35, 90),
			   new Point(95, 90),
			   new Point(70, 115),
			};
			sourceVertices = Triangulator.Triangulator.CutHoleInShape(sourceVertices, holeVertices);
			return sourceVertices;
		}

		private Point[] Star()
        {
			Point[] sourceVertices = new Point[]
			{
			   new Point(0, 0),
			   new Point(210, 0),
			   new Point(210, 150),
			   new Point(0, 150)
			};
			Point[] holeVertices = new Point[]
			{
			   new Point(54.402, 60.551),
			   new Point(68.344, 76.276),
			   new Point(87.648, 67.97),
			   new Point(77.001, 86.088),
			   new Point(90.866, 101.881),
			   new Point(70.344, 97.354),
			   new Point(59.609, 115.421),
			   new Point(57.573, 94.504),
			   new Point(37.073, 89.877),
			   new Point(56.337, 81.477)
			};
			sourceVertices = Triangulator.Triangulator.CutHoleInShape(sourceVertices, holeVertices);
			return sourceVertices;
		}

		private Point[] ManyHoles()
        {
			Point[] sourceVertices = new Point[]
			{
			   new Point(0, 0),
			   new Point(210, 0),
			   new Point(210, 150),
			   new Point(0, 150)
			};
			Point[] holeVertices = new Point[]
			{
			   new Point(160, 30),
			   new Point(200, 15),
			   new Point(195, 30)
			};
			sourceVertices = Triangulator.Triangulator.CutHoleInShape(sourceVertices, holeVertices);
			holeVertices = new Point[]
			{
			   new Point(95, 110),
			   new Point(120, 65),
			   new Point(130, 105),
			   new Point(180, 115),
			   new Point(190, 65),
			   new Point(200, 120),
			   new Point(165, 135)
			};
			sourceVertices = Triangulator.Triangulator.CutHoleInShape(sourceVertices, holeVertices);
			holeVertices = new Point[]
			{
			   new Point(75, 25),
			   new Point(100, 5),
			   new Point(100, 35),
			   new Point(175, 35),
			   new Point(175, 50),
			   new Point(75, 50)
			};
			sourceVertices = Triangulator.Triangulator.CutHoleInShape(sourceVertices, holeVertices);
			holeVertices = new Point[]
			{
			   new Point(150, 75),
			   new Point(175, 75),
			   new Point(175, 100),
			   new Point(150, 100)
			};
			sourceVertices = Triangulator.Triangulator.CutHoleInShape(sourceVertices, holeVertices);
			holeVertices = new Point[]
			{
			   new Point(65, 15),
			   new Point(70, 15),
			   new Point(70, 55),
			   new Point(100, 65),
			   new Point(70, 130),
			   new Point(25, 125),
			   new Point(30, 95),
			   new Point(70, 100),
			   new Point(85, 70),
			   new Point(65, 55)
			};
			sourceVertices = Triangulator.Triangulator.CutHoleInShape(sourceVertices, holeVertices);
			holeVertices = new Point[]
			{
			   new Point(53.44, 60.382),
			   new Point(59.172, 60.911),
			   new Point(64.322, 62.404),
			   new Point(68.685, 64.719),
			   new Point(72.056, 67.717),
			   new Point(74.23, 71.254),
			   new Point(75, 75.191),
			   new Point(74.23, 79.128),
			   new Point(72.056, 82.665),
			   new Point(68.685, 85.663),
			   new Point(64.322, 87.978),
			   new Point(59.172, 89.471),
			   new Point(53.44, 90),
			   new Point(47.708, 89.471),
			   new Point(42.558, 87.978),
			   new Point(38.195, 85.663),
			   new Point(34.824, 82.665),
			   new Point(32.65, 79.128),
			   new Point(31.88, 75.191),
			   new Point(32.65, 71.254),
			   new Point(34.824, 67.717),
			   new Point(38.195, 64.719),
			   new Point(42.558, 62.404),
			   new Point(47.708, 60.911)
			};
			sourceVertices = Triangulator.Triangulator.CutHoleInShape(sourceVertices, holeVertices);
			holeVertices = new Point[]
			{
			   new Point(20, 10),
			   new Point(60, 10),
			   new Point(60, 40),
			   new Point(20, 40)
			};
			sourceVertices = Triangulator.Triangulator.CutHoleInShape(sourceVertices, holeVertices);
			return sourceVertices;
		}

		private Point[] InvisibleInjectionVertex()
        {
			Point[] sourceVertices = new Point[]
			{
			   new Point(0, 0),
			   new Point(210, 0),
			   new Point(210, 150),
			   new Point(150, 150),
			   new Point(150, 75),
			   new Point(125, 75),
			   new Point(125, 150),
			   new Point(0, 150)
			};
			Point[] holeVertices = new Point[]
			{
			   new Point(120, 10),
			   new Point(150, 10),
			   new Point(150, 40),
			   new Point(120, 40)
			};
			sourceVertices = Triangulator.Triangulator.CutHoleInShape(sourceVertices, holeVertices);
			holeVertices = new Point[]
			{
			   new Point(30, 55),
			   new Point(85, 55),
			   new Point(45, 95)
			};
			sourceVertices = Triangulator.Triangulator.CutHoleInShape(sourceVertices, holeVertices);
			return sourceVertices;
		}

		private Point[] DoubleInjectionPointOnRay()
        {
			Point[] sourceVertices = new Point[]
			{
			   new Point(0, 0),
			   new Point(210, 0),
			   new Point(210, 150),
			   new Point(0, 150)
			};
			Point[] holeVertices = new Point[]
			{
			   new Point(125, 50),
			   new Point(150, 50),
			   new Point(150, 100),
			   new Point(125, 100)
			};
			sourceVertices = Triangulator.Triangulator.CutHoleInShape(sourceVertices, holeVertices);
			holeVertices = new Point[]
			{
			   new Point(75, 50),
			   new Point(100, 50),
			   new Point(100, 75),
			   new Point(75, 75)
			};
			sourceVertices = Triangulator.Triangulator.CutHoleInShape(sourceVertices, holeVertices);
			holeVertices = new Point[]
			{
			   new Point(25, 50),
			   new Point(50, 50),
			   new Point(50, 100),
			   new Point(25, 100)
			};
			sourceVertices = Triangulator.Triangulator.CutHoleInShape(sourceVertices, holeVertices);
			return sourceVertices;
		}

		private void CreateGeometry()
		{
			Point[] sourceVertices = null;
			switch (Example)
            {
				case 0:
					sourceVertices = OriginalExample();
					break;
				case 1:
					sourceVertices = AlignedHolesOnRight();
					break;
				case 2:
					sourceVertices = PolygonPointOnRay();
					break;
				case 3:
					sourceVertices = DoubleInjectionPointOnRay();
					break;
				case 4:
					sourceVertices = InvisibleInjectionVertex();
					break;
				case 5:
					sourceVertices = Star();
					break;
				case 6:
					sourceVertices = ManyHoles();
					break;
			}

			// create a variable for the indices and triangulate the object
			int[] sourceIndices;
			Triangulator.Triangulator.Triangulate(
				sourceVertices,
				Triangulator.WindingOrder.Clockwise,
				out sourceVertices,
				out sourceIndices);

			paintSurface.Children.Clear();
			int index = 0;
			while (index < sourceIndices.Length)
            {
				Polygon triangle = new Polygon();
				triangle.Points.Add(sourceVertices[sourceIndices[index++]]);
				triangle.Points.Add(sourceVertices[sourceIndices[index++]]);
				triangle.Points.Add(sourceVertices[sourceIndices[index++]]);
				triangle.StrokeEndLineCap = PenLineCap.Round;
				triangle.StrokeStartLineCap = PenLineCap.Round;
				triangle.StrokeLineJoin = PenLineJoin.Round;
				triangle.Stroke = Brushes.Black;
				triangle.Fill = Brushes.LightBlue;
				triangle.StrokeThickness = 1;
				paintSurface.Children.Add(triangle);
            }
		}

        private void PreviousClick(object sender, RoutedEventArgs e)
        {
			if (Example>0)
				Example--;
			CreateGeometry();
        }

        private void NextClick(object sender, RoutedEventArgs e)
        {
			if (Example < 6)
				Example++;
			CreateGeometry();
		}
	}
}