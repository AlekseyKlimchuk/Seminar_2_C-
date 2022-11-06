//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Программа, которая принимает на вход цифру, обозначащую день недели, и проверяет, является ли этот день недели выходным");
Console.WriteLine("Введите число от 1 до 7: ");
int numA = int.Parse(Console.ReadLine()!);


void DefWeekend (int numA) 
{
if ((numA > 0) && (numA < 8))
{
    if (numA == 1) Console.WriteLine("Нет");
    if (numA == 2) Console.WriteLine("Нет");
    if (numA == 3) Console.WriteLine("Нет");
    if (numA == 4) Console.WriteLine("Нет");
    if (numA == 5) Console.WriteLine("Нет");
    if (numA == 6) Console.WriteLine("Да");
    if (numA == 7) Console.WriteLine("Да");
}
else {
    Console.WriteLine("Неправильный ввод! Введите число от 1 до 7");
}
}
DefWeekend(numA);