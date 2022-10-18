Задача 19
Console.WriteLine("Введите число");
string? number = Console.ReadLine();

void CheckingNumber(string number){
    if (number[0] == number[4] || number[1] == number[3]){
    Console.WriteLine($"Ваше число:{number} - палиндром.");
    }

    else 
        Console.WriteLine($"Ваше число: {number} - не палиндром");
    }
    if (number!.Length == 5) {
        CheckingNumber(number);
    }
    else 
        Console.WriteLine($"Введите правильное число");



Задача 21
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите координаты точки А через пробел");
        string xyz = Console.ReadLine()!;
        string[] partsA = xyz.Split(' ');
        int xA = int.Parse(partsA[0]);
        int yA = int.Parse(partsA[1]);
        int zA = int.Parse(partsA[2]);

        Console.WriteLine("Введите координаты точки B через пробел");
        xyz = Console.ReadLine()!;
        string[] partsB = xyz.Split(' ');
        int xB = int.Parse(partsB[0]);
        int yB = int.Parse(partsB[1]);
        int zB = int.Parse(partsB[2]);

        double distsnce = Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2) + Math.Pow(zB - zA, 2));

        Console.WriteLine($"Расстояние между точкой А и точкой B = {distsnce:F2}");
    }
}


Задача 23
int n = ReadInt("Введите число: ");
int count = 1;
while (count < n + 1)
{
    Console.Write($"{count * count * count} ");
    count++;
}
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
