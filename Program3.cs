using System;

public class Point 
{
    private int x;
    private int y;

    public Point()
    {
        this.x = 0;
        this.y = 0;
    }

    public Point(int x, int y) 
    {
        this.x = x;
        this.y = y;
    }
    public int Y 
    {
        get 
        {
            return y;
        }
    }

    public int X
    {
        get
        {
            return x;
        }
    }
}

public class Figure 
{
    private Point p1, p2, p3, p4, p5;
    public string name { get; set; }
    public Figure(Point p1, Point p2, Point p3) 
    {
        this.p1 = p1;
        this.p2 = p2;
        this.p3 = p3;
        name = "треугольник";
    }

    public Figure(Point p1, Point p2, Point p3, Point p4): this(p1,p2,p3)
    {
        this.p4 = p4;
        name = "четырехугольник";
    }

    public Figure(Point p1, Point p2, Point p3, Point p4, Point p5): this(p1, p2, p3, p4)
    {
        this.p5 = p5;
        name = "пятиугольник";
    }

    public static double LengthSide(Point A, Point B) 
    {
        return Math.Sqrt(Math.Pow(A.X - B.X, 2) + Math.Pow(A.Y - B.Y, 2));
    }

    public double PerimeterCalculator(params Point[] parameters) 
    {
        double result = 0;
        Point p0 = parameters[0];
        Point pend = parameters[parameters.Length-1];
        for (int i = 0; i < parameters.Length-1; ++i) 
        {
            result += LengthSide(parameters[i], parameters[i+1]);
        }
        result += LengthSide(p0, pend);
        return result;
    }
}

namespace Task3
{
    public class Program
    {
        static void Main()
        {
            Point p1 = new Point(1, 2);
            Point p2 = new Point(3, 4);
            Point p3 = new Point(5, 6);
            Point p4 = new Point(7, 8);
            Point p5 = new Point(9, 10);
            Figure f1 = new Figure(p1, p2, p3);
            Console.WriteLine($"Фигура: {f1.name}, периметр: {f1.PerimeterCalculator(p1, p2, p3)}");
            Figure f2 = new Figure(p1, p2, p3, p4);
            Console.WriteLine($"Фигура: {f2.name}, периметр: {f2.PerimeterCalculator(p1, p2, p3, p4)}");
            Figure f3 = new Figure(p1, p2, p3, p4, p5);
            Console.WriteLine($"Фигура: {f3.name}, периметр: {f3.PerimeterCalculator(p1, p2, p3, p4, p5)}");
        }
    }
}
