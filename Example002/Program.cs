//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int length = number.Length;

if (length>=3)
{
  Console.WriteLine(number[2]);
}
else
{
  Console.WriteLine("третьей цифры нет");
}