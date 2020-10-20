using System;

namespace HomeworkClassTask3
{
    class Rectangle
    {
        private int a;
        private int b;
        public int A
        {
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Прямоугольник не существует.");
                }
                else
                {
                    a = value;
                }
            }
            get
            {
                return a;
            }
        }
        public int B
        {
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Прямоугольник не существует.");
                }
                else
                {
                    b = value;
                }
            }
            get
            {
                return b;
            }
        }
        public Rectangle()
        {
            Console.WriteLine("Введите сторону A и сторону B");
            A = Program.EnterNum();
            B = Program.EnterNum();
            ShowSides();
            Perimeter();
            Area();
            isSquare();
        }
        void ShowSides()
        {
            Console.WriteLine($"Длины сторон прямоугольника равны {a}, {b}, {a}, {b}.");
        }
        void Perimeter()
        {
            Console.WriteLine($"Периметр прямоугольника равен: {a + b + a + b}.");
        }
        void Area()
        {
            Console.WriteLine($"Площадь прямоугольника равна: {a*b}.");
        }
        void isSquare()
        {
            if (a == b)
            {
                Console.WriteLine("Прямоугольник является квадратом.");
            }
            else
            {
                Console.WriteLine("Прямоугольник не является квадратом.");
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            Console.ReadKey();
        }
        public static int EnterNum()
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
