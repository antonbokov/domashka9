Задача 41

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите числа через запятую: ");
        int[] numbers = StringNumbers(Console.ReadLine()!);
        PrintArray(numbers);

        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > 0)
            {
                sum++;
            }
        }
        Console.WriteLine();
        Console.WriteLine($"количество значений больше 0 = {sum}");
        int[] StringNumbers(string input)
        {
            int count = 1;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ',')
                {
                    count++;
                }
            }
            int[] numbers = new int[count];
            int index = 0;

            for (int i = 0; i < input.Length; i++)
            {
                string temp = "";

                while (input[i] != ',')
                {
                    if (i != input.Length - 1)
                    {
                        temp += input[i].ToString();
                        i++;
                    }
                    else
                    {
                        temp += input[i].ToString();
                        break;
                    }
                }
                numbers[index] = Convert.ToInt32(temp);
                index++;
            }
            return numbers;
        }
        void PrintArray(int[] array)
        {
            Console.Write("[ ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.Write("]");
        }
    }
}


Задача 43

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите b1: ");
        var b1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите k1: ");
        var k1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите b2: ");
        var b2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите k2: ");
        var k2 = Convert.ToDouble(Console.ReadLine());


        var x = -(b1 - b2) / (k1 - k2);
        var y = k1 * x + b1;

        x = Math.Round(x, 3);
        y = Math.Round(y, 3);

        Console.WriteLine($"Пересечение в точке: ({x};{y})");
    }
}