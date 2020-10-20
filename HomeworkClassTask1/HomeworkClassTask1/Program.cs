using System;

namespace HomeworkClassTask1
{
    public class Point
    {
        int X { get; set; }
        int Y { get; set; }

        public Point()
        {
            ShowCoordinates();
        }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
            ShowCoordinates();
            FindDistance();
            ChangePosition();
            Scalar();
        }
        void ShowCoordinates()
        {
            Console.WriteLine($"Координаты вашей точки это ({X},{Y})");
        }
        void FindDistance()
        {
            Console.WriteLine($"Расстояние от начала координат до точки равно: {Math.Sqrt(X*X+Y*Y)}.");
        }
        void ChangePosition()
        {
            Console.WriteLine("Введите вектор.");
            Console.WriteLine("Введите a.");
            int a = Program.EnterNum();
            Console.WriteLine("Введите b.");
            int b = Program.EnterNum();
            Console.WriteLine($"Ваша точка перемещенная на вектор (a,b): {X+a}, {Y+b}.");
        }
        void Scalar()
        {
            Console.WriteLine("Введите скаляр.");
            Console.WriteLine("Введите m.");
            int m = Program.EnterNum();
            Console.WriteLine("Введите n.");
            int n = Program.EnterNum();
            int scalar1 = X * m;
            int scalar2 = Y * n;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координату Х."); 
            int CoordinateX = EnterNum();
            Console.WriteLine("Введите координату Y.");
            int CoordinateY = EnterNum();
            Console.WriteLine("Точка с заданными координатами.");
            Point point1 = new Point(CoordinateX, CoordinateY);
            Console.WriteLine("Точка с нулевыми координатами.");
            Point point2 = new Point();
            Console.ReadKey();

        }
       public static int  EnterNum()
        {
                bool isRight = false;
                int number;
                do
                {
                    if (Int32.TryParse(Console.ReadLine(), out number))
                    {
                        isRight = true;
                    }
                    else
                    {
                        Console.WriteLine("Введено неверное значение!");
                        Console.WriteLine("Введите еще раз.");
                        isRight = false;
                    }
                }
                while (isRight == false);
                return number;
            
        }
        
    }

}
