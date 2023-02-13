/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
 что третьей цифры нет.Через строку решать нельзя.

645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

int number = new Random().Next(1, 100000000);
int result = -1;
string message = "третьей цифры нет";
if (number >= 100)
{
    while (number > 999)
    {
        number = number / 10;
    }
    result = number % 10;
}
if (result == -1)
{
    Console.WriteLine(message);
}
else
{
    Console.WriteLine(result);
}
