using System;

namespace HomeworkClassTask4
{
    class Money
    {
        private int first;
        private int second;
        public int First
        {
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Значение не может быть отрицательным или равно нулю.");
                }
                else
                {
                    first = value;
                }
            }
            get
            {
                return first;
            }
        }
        public int Second
        {  
                set
                {
                    if (value <= 0)
                    {
                        Console.WriteLine("Значение не может быть отрицательным или равно нулю.");
                    }
                    else
                    {
                        second = value;
                    }
                }
                get
                {
                    return second;
                }
        }
        public Money()
        {
            Console.WriteLine("Введите номинал купюры.");
            First = Program.EnterNum();

            Console.WriteLine("Введите количетво купюр.");
            Second = Program.EnterNum();
            Sum();
            ShowInfo();
            Console.WriteLine("Введите сумму необходимую для покупки товара.");
            int N = Program.EnterNum();
            HaveMoney(N);
            HowMany(N);
        }
        void ShowInfo()
        {
            Console.WriteLine($"Номинал купюры равен {first}, количество купюр равно {second}.");
        }
        void HaveMoney(int N)
        {
            
            if (first * second >= N)
            {
                Console.WriteLine("Вам хватит денег на покупку товара.");
            }
            else
            {
                Console.WriteLine("Вам не хватит денег на покупку товара.");
            }
        }
        void HowMany(int N)
        {
            if (first * second > N)
            {
                Console.WriteLine($"Вы можете купить {(int)first * second / N} шт товара.");
            }
            if (first * second == N)
            {
                Console.WriteLine("Вы можете купить 1 шт товара.");
            }


        }
        void Sum()
        {
            int sum = first * second;
            Console.WriteLine($"Сумма денег равна: {sum}.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Money money1 = new Money();
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
