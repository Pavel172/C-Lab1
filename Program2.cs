using System;


namespace Task2
{

    public class Rectangle 
    {
        private double sideA;
        private double sideB;
        public Rectangle(double sideA, double sideB) 
        {
            this.sideA = sideA;
            this.sideB = sideB;
        }

        public double CalculateArea() 
        {
            return sideA * sideB;
        }

        public double CalculatePerimeter() 
        {
            return (sideA + sideB) * 2;
        }

        public double Area 
        {
            get 
            {
                return CalculateArea();
            }
        }

        public double Perimeter 
        {
            get 
            {
                return CalculatePerimeter();
            }
        }
    }


    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Напишите длину прямоугольника:");
            string temp1 = Console.ReadLine();
            double length = Convert.ToInt32(temp1);
            Console.WriteLine("Напишите ширину прямоугольника:");
            string temp2 = Console.ReadLine();
            double width = Convert.ToInt32(temp2);
            Rectangle Rec = new Rectangle(length, width);
            Console.WriteLine($"Площадь: { Rec.Area}");
            Console.WriteLine($"Периметр: { Rec.Perimeter}");
        }
    }
}
