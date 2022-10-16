Задача 10
int number = ReadInt("Введите трехзначное число: ");
int result = number % 100;
if(number>99 && number<1000)
{
    result=result/10;
    Console.WriteLine("Вторая цифра введенного числа " + result);
}
else 
{
    Console.WriteLine("Ошибка! Введите трехзначное число!");
}
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


Задача 13
int number = ReadInt("Введите число: ");
if (number>99 || number<-99)
{
    do {number = number / 10;}
    while (number>999 || number<-999);
    if(number<0)
    {
        number = number * (-1); 
    }
    Console.WriteLine(number%10);
}
else 
{
    Console.WriteLine("В введенном числе нет третьей цифры");
}
int ReadInt (string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}


Задача 15
Console.Write("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
void CheckingTheDayOfTheWeek (int dayNumber) {
  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine("(этот день выходной) -> да");
  }
  else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("это вообще не день недели");
  }
  else Console.WriteLine("(этот день не выходной) -> нет");
}
CheckingTheDayOfTheWeek(dayNumber);