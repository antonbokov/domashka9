Задача 54

class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите количество строк");
            int linesVol = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите количество столбцов");
            int columnsVol = Convert.ToInt32(Console.ReadLine());
            int[,] numbers = new int[linesVol, columnsVol];
            FillArrayRandomNumbers(numbers);
            Console.WriteLine();
            Console.WriteLine("Массив до изменения");
            PrintArray(numbers);
            
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1) - 1; j++)
                {
                    for (int z = 0; z < numbers.GetLength(1) - 1; z++)
                    {
                        if (numbers[i, z] < numbers[i, z + 1]) //для изменения сортировки поменять знак < на противоположный
                        {
                            int temp = 0;
                            temp = numbers[i, z];
                            numbers[i, z] = numbers[i, z + 1];
                            numbers[i, z + 1] = temp;
                        }
                   }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Массив с упорядоченными значениями");
            PrintArray(numbers);
            
            void FillArrayRandomNumbers(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array[i, j] = new Random().Next(0, 10);
                    }
                }
            }
            void PrintArray(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    Console.Write("[ ");
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write(array[i, j] + " ");
                    }
                    Console.Write("]");
                    Console.WriteLine("");
                }
            }
        }
    }


Задача 56

class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите размер квадратного массива");
            int massVol = Convert.ToInt32(Console.ReadLine());
            int[,] numbers = new int[massVol, massVol];
            FillArrayRandomNumbers(numbers);
            PrintArray(numbers);
            int minsum = Int32.MaxValue;
            int indexLine = 0;
            
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                   sum = sum + numbers[i, j];
                }
                if (sum < minsum)
                {
                    minsum = sum;
                    indexLine++;
                }
            }
            
            Console.WriteLine("строка с наименьшей суммой елементов под номером: " + (indexLine) + ", с суммой елементов равной: " + (minsum));
            
            void FillArrayRandomNumbers(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array[i, j] = new Random().Next(0, 10);
                    }
                }
            }
            
            void PrintArray(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    Console.Write("[ ");
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write(array[i, j] + " ");
                    }
                    Console.Write("]");
                    Console.WriteLine("");
                }
            }
        }
    }



Задача 58

class Program
    {
        static void Main(string[] args)
        {
            int rows = ReadInt("Введите количество строк: ");
            int columns = ReadInt("Введите количество столбцов: ");
            int[,] array = new int[rows, columns];
            int[,] secondArray = new int[rows, columns];
            int[,] resultArray = new int[rows, columns];
            
            FillArrayRandom(array);
            PrintArray2D(array);
            
            Console.WriteLine();
            
            FillArrayRandom(secondArray);
            PrintArray2D(secondArray);
            
            Console.WriteLine();
            
            if (array.GetLength(0) != secondArray.GetLength(1))
            {
                Console.WriteLine(" Нельзя перемножить ");
                return;
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < secondArray.GetLength(1); j++)
                {
                    resultArray[i, j] = 0;
                    for (int k = 0; k < array.GetLength(1); k++)
                    {
                       resultArray[i, j] += array[i, k] * secondArray[k, j];
                    }
                }
            }
            
            PrintArray2D(resultArray);
            
            
            
            // Функция ввода
            int ReadInt(string message)
            {
                Console.Write(message);
                return Convert.ToInt32(Console.ReadLine());
            }
            
            // Функция заполнения массива рандомными числами от 1 до 9
            void FillArrayRandom(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array[i, j] = new Random().Next(1, 10);
                    }
                }
            }
            
            // Функция вывода двумерного массива в терминал 
            void PrintArray2D(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write($"{array[i, j]} ");
                    }
                    Console.WriteLine();
                }
            }            
        }
    }



    Задача 60

     class Program
    {
        static void Main(string[] args)
        {
            int deep1 = InputInt("Введите размерность 1: ");
            int deep2 = InputInt("Введите размерность 2: ");
            int deep3 = InputInt("Введите размерность 3: ");
            int countNums = 89;
            
            if (deep1 * deep2 * deep3 > countNums)
            {
               Console.Write("Массив слишком большой");
                return;
            }
            
            int[,,] resultNums = Create3DMassive(deep1, deep2, deep3);
            
            for (int i = 0; i < resultNums.GetLength(0); i++)
            {
                for (int j = 0; j < resultNums.GetLength(1); j++)
                {
                    for (int k = 0; k < resultNums.GetLength(2); k++)
                    {
                        Console.WriteLine($"[{i},{j},{k}] - {resultNums[i, j, k]}");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            
            
            int[,,] Create3DMassive(int size1, int size2, int size3)
            {
                int[,,] array = new int[size1, size2, size3];
                int[] values = new int[countNums];
                int num
                = 10;
                for (int i = 0; i < values.Length; i++)
                values[i] = num
                ++;
                
                for (int i = 0; i < values.Length; i++)
                {
                    int randomInd = new Random().Next(0, values.Length);
                    int temp = values[i];
                    values[i] = values[randomInd];
                    values[randomInd] = temp;
                }
                
                int valueIndex = 0;
                
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        for (int k = 0; k < array.GetLength(2); k++)
                        {
                            array[i, j, k] = values[valueIndex++];
                        }
                    }
                }
                return array;
            }
            
            
            int InputInt(string output)
            {
                Console.Write(output);
                return int.Parse(Console.ReadLine());
            }
        }
    }



    Задача 62

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива");
            int size = Convert.ToInt32(Console.ReadLine());
            
            int[,] nums = new int[size, size];
            
            int num = 1;
            int i = 0;
            int j = 0;
            
            while (num <= size * size)
            {
                nums[i, j] = num;
                if (i <= j + 1 && i + j < size - 1)
                ++j;
                else if (i < j && i + j >= size - 1)
                ++i;
                else if (i >= j && i + j > size - 1)
                --j;
                else
                --i;
                ++num;
            }
            
            PrintArray(nums);
            
            void PrintArray(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    Console.Write("[ ");
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                       Console.Write(array[i, j] + " ");
                    }
                    Console.Write("]");
                    Console.WriteLine("");
                }
            }
        }
    }



    