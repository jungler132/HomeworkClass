using System;

namespace HomeworkClassTask2
{
    class Triangle
    {
        private int a;
        private int b;
        private int c;
        public int A
        {
            set
            {
                if (value <=0)
                {
                    Console.WriteLine("Треугольник не может существовать.");
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
                if (value <=0)
                {
                    Console.WriteLine("Треугольник не может существовать.");
                    
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
        public int C
        {
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Треугольник не может существовать.");
                }
                else
                {
                    c = value;
                }
            }
            get
            {
                return c;
            }
        }
        public Triangle()
        {
            Console.WriteLine("Введите значения для сторон треугольника.");
            A = Program.EnterNum();
            B = Program.EnterNum();
            C = Program.EnterNum();

            Perimeter();
            ShowSides();
            Area();
        }
        void ShowSides()
        {
            Console.WriteLine($"Длины сторон треугольника равны: {a}, {b}, {c}.");
        }
        void Perimeter()
        {
            Console.WriteLine($"Периметр треугольника равен: {a + b + c}.");
        }
        void Area()
        {
            int p = (a + b + c) / 2;
            Console.WriteLine($"Площадь треугольника равна: {Math.Sqrt(p*(p-a)*(p-b)*(p-c))}");
        }
        void isReal()
        {
            if(a<b+c && b<a+c && c < a + b)
            {
                Console.WriteLine("Треугольник существует.");
            }
            else
            {
                Console.WriteLine("Треугольник не существует.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Triangle tri = new Triangle();
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
