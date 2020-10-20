using System;

namespace HomeworkClassTask6
{
    class TwoArray
    {
        double[,] DoubleArray;
        private int n;
        private int m;
        public int N
        {
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Вам необходимо больше значений.");
                }
                else
                {
                    n = value;
                }
            }
            get
            {
                return n;
            }
        }
        public int M
        {
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Вам необходимо больше значений.");
                }
                else
                {
                    m = value;
                }
            }
            get
            {
                return m;
            }
        }
        public TwoArray()
        {
            Console.WriteLine("Введите количество строк.");
            N = Program.EnterNum();
            Console.WriteLine("Введите количество столбцов.");
            M = Program.EnterNum();
            DoubleArray = new double[n, m];
            DoubleArray = EnterArrayElements();
            ShowElements();
            SortArray();
            Scalar();
            AllElements();


        }
       double[,] EnterArrayElements()
        {
            int rows = DoubleArray.GetUpperBound(0) + 1;
            int columns = DoubleArray.Length / rows;
            for (int i = 0; i<rows; i++)
            {
                for (int j = 0; j< columns; j++)
                {
                    Console.WriteLine($"Введите элемент [{i},{j}]");
                    DoubleArray[i, j] = Program.EnterNum();

                }
            }
            return DoubleArray;
        }
        void ShowElements()
        {
            int rows = DoubleArray.GetUpperBound(0) + 1;
            int columns = DoubleArray.Length / rows;
            Console.WriteLine("\nЭлементы массива:");
            for (int i = 0; i < rows; i++)
            {
               
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(DoubleArray[i, j] + "; ");

                }
            }
        }
        void SortArray()
        {
            int rows = DoubleArray.GetUpperBound(0) + 1;
            int columns = DoubleArray.Length / rows;
            for (int i = 0; i < rows; i++)
            {
                
                for (int j = 0; j < columns-1; j++)
                {
                   for(int e = j+1; e<columns; e++)
                    {
                        double fortime;
                        if(DoubleArray[i, j] < DoubleArray[i, e])
                        {
                            fortime = DoubleArray[i, j];
                            DoubleArray[i, j] = DoubleArray[i, e];
                            DoubleArray[i, e] = fortime;
                        }
                    }

                }
            }
            Console.WriteLine("\nОтсортированные строки:");
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine($"\nСтрока {i+1}");
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(DoubleArray[i, j] + "; ");

                }
            }

        }
        double[,] Scalar()
        {
            int rows = DoubleArray.GetUpperBound(0) + 1;
            int columns = DoubleArray.Length / rows;
            Console.WriteLine("\nВведите скаляр.");
            int scalar = Program.EnterNum();
            double temp;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    temp = DoubleArray[i, j] + scalar;
                    DoubleArray[i, j] = temp;

                }
            }
            return DoubleArray;
        }
        void AllElements()
        {
            Console.WriteLine($"Общее количество элементов в массиве: {n * m}");
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            TwoArray array1 = new TwoArray();
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
            Console.ReadKey();
            return number;
        }
    }
}
