using System;

namespace HomeworkClassTask5
{
    class ArrayWork
    {
        int[] IntArray { get; set; }
        private int n;
        public int N
        {
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Вам необходимо большее количество переменых.");

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
        public ArrayWork()
        {
            Console.WriteLine("Введите количество элементов массива.");
            N = Program.EnterNum();
            IntArray = new int[n];
            IntArray = NumbersOfArray();
            ShowElements();
            SortArray();
            MultiplyScalar();
            Console.WriteLine("Массив является одномерным.");
        }
        int[] NumbersOfArray()
        {
            for(int i =0; i< IntArray.Length; i++)
            {
                Console.WriteLine($"Введите значение для элемента с индексом {i}");
                IntArray[i] = Program.EnterNum();
            }
            return IntArray;
        }
        void ShowElements()
        {
            Console.WriteLine("Элементы массива:");
            for (int i=0; i< IntArray.Length; i++)
            {
                Console.Write(IntArray[i] + "; ");

            }
        }
        void SortArray()
        {
            Console.WriteLine("\nОтсортированный массив:");
            for (int i = 0; i<IntArray.Length-1; i++)
            {
                for(int j = i+1; j<IntArray.Length; j++)
                {
                    int temp;
                    if (IntArray[i] > IntArray[j])
                    {
                        temp = IntArray[j];
                        IntArray[j] = IntArray[i];
                        IntArray[i] = temp;
                    }
                }
            }
            for(int i =0; i<IntArray.Length; i++)
            {
                Console.Write(IntArray[i] + "; ");
            }

        }
        void MultiplyScalar()
        {
            Console.WriteLine("\nВведите скаляр, на который нужно умножить элементы массива.");
            int scalar = Program.EnterNum();
            int fortime;
            for(int i = 0; i < IntArray.Length; i++)
            {
               fortime = IntArray[i] * scalar;
                IntArray[i] = fortime;
            }
           /* Console.WriteLine("Cкаляр");
            for (int j = 0; j < IntArray.Length; j++)
            {
                Console.Write(IntArray[j] + "; ");
            }*/


        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            ArrayWork Array1 = new ArrayWork();
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
