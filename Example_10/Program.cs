//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine("Программа, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа");
Console.WriteLine("Введите трехзначное число: ");
int numA = int.Parse(Console.ReadLine());

void res (int NumA)
{
    int FirstDigit = numA % 100;
    int SecondDigit = FirstDigit / 10;
    Console.WriteLine(SecondDigit);
}
res (numA);