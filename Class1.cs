using System;

namespace ClassLibrary2
{
    class Point
    {
        private int x, y;
        public Point() { }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int X { get { return x; } }
        public int Y { get { return y; } }
    }
    class Figure
    {
    public string NameOfFigure { get; set; }
    private Point[] Points;
    public Figure(string NameOfFigure, params Point[] Points)
    {
        if(!(Points.Length > 2 && Points.Length < 6))
        {
            throw new ArgumentException("In Figure Constructor Must Be Transfered From 3 To 5 Points");
        }
        this.NameOfFigure = NameOfFigure;
        this.Points = Points;
    }
    public Figure(Point Point1, Point Point2, Point Point3) : this("Figure", Point1, Point2, Point3) {}
    public Figure(Point Point1, Point Point2, Point Point3, Point Point4) : this("Figure", Point1, Point2, Point3, Point4) {}
    public Figure(Point Point1, Point Point2, Point Point3, Point Point4, Point Point5) : this("Figure", Point1, Point2, Point3, Point4, Point5) {}
    public double LengthSide(Point PointA, Point PointB) 
    {
        return Math.Sqrt(Math.Pow(PointB.X - PointA.X, 2) + Math.Pow(PointB.Y - PointA.Y, 2));
    }
    public double Perimeter()
    {
        double Result = LengthSide(Points[Points.Length - 1], Points[0]);
        for(int i = 0; i < Points.Length - 1; i++)
        {
            Result += LengthSide(Points[i], Points[i + 1]);
        }
        return Result;
    }
    
    }
}
