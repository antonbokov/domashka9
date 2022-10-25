
Задача 34

Console.WriteLine("Введите длину массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
RandonNumbers(numbers);
Console.WriteLine("В этом массиве: ");
PrintArray(numbers);

void RandonNumbers(int[] numbers)
{
    for(int i = 0; i < size; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}

int count = 0;

for (int x = 0; x < numbers.Length; x++)
{
if (numbers[x] % 2 == 0)
count++;
}
Console.WriteLine($"из {numbers.Length} чисел, {count} четных");


void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}




Задача 36


Console.WriteLine($"Введи длину массива: ");
int ElementNumbers = Convert.ToInt32(Console.ReadLine()); 
int randomNumber =  RandomNumbers(ElementNumbers, 1, 10);
Console.WriteLine($"  Сумма элементов, стоящих на нечётных позициях: {randomNumber}");

int RandomNumbers(int ElementNumbers, int min, int max)
  {
  int[] randomNumber = new int[ElementNumbers];
  int sumElements = 0;
  Console.Write("Получившийся массив: ");

    for (int i = 0; i <randomNumber.Length; i++ ){
      randomNumber[i] = new Random().Next(min, max);

      Console.Write(randomNumber[i] + " ");

      if (i % 2 != 1)
      {
        sumElements = sumElements + randomNumber[i];
      }
    }
  return sumElements;
  }


Задача 38

double[] GetArray(int size, int minValue, int maxValue)
{
    double[] res = new double[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

double MaxElement(double[] arr)
{
    double maxel = arr [0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > maxel)
        {
            maxel = arr[i];
        
        }
    }   
    return maxel;
}

double MinElement(double[] arr)
{
    double minel = arr [0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > minel)
        {
            minel = arr[i];
        
        }
    }   
    return minel;
}

Console.Clear();
Console.WriteLine("Введите длину массива: ");
int n = Int16.Parse(Console.ReadLine()!);

double[] arr = GetArray(n, 1, 1000);
Console.WriteLine(String.Join(",", arr));

double min = MinElement(arr);
double max = MaxElement(arr);
Console.WriteLine($"Разница между мин и макс значением массива: {min - max}");