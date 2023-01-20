//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

int GetRandomValue()
{
    return new Random().Next(100, 1000);
}

int FindThirdNumber(int number)
{
    return (number / 10) %10;
}

int number = GetRandomValue();
int result = FindThirdNumber(number);
Console.WriteLine(number);
Console.WriteLine(result);