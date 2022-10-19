Задача 25

void PowMethod(int num, int pow)
{
    int result = 1;
    if (pow <= 0)
    {
        Console.WriteLine("Введенная степень не является натуральной");
    }
    else
    {
        for (int i = 1; i <= pow; i++)
            result = result * num;
        Console.WriteLine($"Число {num} в степени {pow} равно {result}");
    }
}
Console.Write("Введите ваше число: ");
    int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральную степень: ");
    int pow = Convert.ToInt32(Console.ReadLine());
PowMethod(num, pow);



Задача 27

void SumOfNum(int num)
{
    int sum = 0;
    while (num != 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    Console.WriteLine(sum);
}
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
SumOfNum(num);



Задача 29

Console.WriteLine("Введите массив из 8 чисел");
string input = Console.ReadLine() ??"";
string[] temp = input.Split(' ');

int[] resultArray = new int[temp.Length];
for (int i = 0; i < resultArray.Length; i++)
{
    resultArray[i] = int.Parse(temp[i]);
}
for (int i = 0; i < resultArray.Length; i++)
{
    Console.Write($"{resultArray[i]}, ");
}

