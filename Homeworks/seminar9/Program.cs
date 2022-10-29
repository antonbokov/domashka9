Задача 64

class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число больше 1:");
            int number = int.Parse(Console.ReadLine());
            
            void NumberCounter(int number)
            {
                if (number < 0) Console.Write($"{number} не натуральное число");
                if (number == 0) return;
                Console.Write("{0,4}", number);
                NumberCounter(number - 1);
            }
            
            NumberCounter(number);            
        }
    }


Задача 66

class Program
    {
        static void Main(string[] args)
        {
            int m = InputNumbers("Введите m: ");
            int n = InputNumbers("Введите n: ");
            int temp = m;
            
            if (m > n)
            {
                m = n;
                n = temp;
            }
            
            PrintSumm(m, n, temp=0);
            
            void PrintSumm(int m, int n, int summ)
            {
                summ = summ + n;
                if (n <= m)
                {
                    Console.Write($"Сумма элементов= {summ} ");
                    return;
                }
                PrintSumm(m, n - 1, summ);
            }

            int InputNumbers(string input)
            {
                Console.Write(input);
                int output = Convert.ToInt32(Console.ReadLine());
                return output;
            }
        }
    }



Задача 68

class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число M: ");
            int m = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Введите число N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            
            AkkermanFunction(m,n);
                        
            // вызов функции Аккермана
            void AkkermanFunction(int m, int n)
            {
               Console.Write(Akkerman(m, n));
            }
            
            // функция Аккермана
            int Akkerman(int m, int n)
            {
                if (m == 0)
                {
                   return n + 1;
                }
                else if (n == 0 && m > 0)
                {
                   return Akkerman(m - 1, 1);
                }
                else
                {
                   return (Akkerman(m - 1, Akkerman(m, n - 1)));
                }
            }
        }
    }