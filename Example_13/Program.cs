// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет");
Console.WriteLine("Введите  число: ");
int numA = int.Parse(Console.ReadLine());

void DefThirdDigit(int numA)
{
    int FirstDigit = numA % 100;
    int SecondDigit = (numA - FirstDigit * 100) / 10;
    int ThirdDigit = numA % 10;


    if (numA < 100)
    {
        Console.WriteLine("Третей цифры нет");
    }
    else
    {
        Console.WriteLine("Третье число: " + ThirdDigit);
    }
}
DefThirdDigit(numA);