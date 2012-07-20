using System.Windows.Controls;
using System.Windows.Media;

namespace TicTakToe
{
    /// <summary>
    /// Interaction logic for BoardCellView.xaml
    /// </summary>
    public partial class BoardCellView : UserControl
    {
        private IBoardCell _cell = BoardCellSafeNull.Instance;

        public BoardCellView()
        {
            InitializeComponent();
        }

        public IBoardCell Cell
        {
            set { _cell = value; }
        }

        protected override void OnRender(System.Windows.Media.DrawingContext drawingContext)
        {
            base.OnRender(drawingContext);

            

            // allows the points to be rendered as an image that can be further manipulated
            PathGeometry geometry = new PathGeometry();
            this.Siz

            // Add all points to the geometry
            foreach (Points pointXY in _points)
            {
                PathFigure figure = new PathFigure();
                figure.StartPoint = pointXY.FromPoint;
                figure.Segments.Add(new LineSegment(pointXY.ToPoint, true));
                geometry.Figures.Add(figure);
            }

            // Add the first point to close the gap from the graph's end point
            // to graph's start point
            PathFigure lastFigure = new PathFigure();
            lastFigure.StartPoint = _points[_points.Count - 1].FromPoint;
            lastFigure.Segments.Add(new LineSegment(_firstPoint, true));
            geometry.Figures.Add(lastFigure);

            // Create a new drawing and drawing group in order to apply
            // a custom drawing effect
            GeometryDrawing drawing = new GeometryDrawing(this.Pen.Brush, this.Pen, geometry);
            DrawingGroup drawingGroup = new DrawingGroup();
            drawingGroup.Children.Add(drawing);
        }
    }
}