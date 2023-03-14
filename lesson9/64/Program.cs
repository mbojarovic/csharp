/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

int Input(string message)
{
    Console.WriteLine(message);
    int msg = Convert.ToInt32(Console.ReadLine());
    return msg;
}
int b1 = Input("значения N");

string WriteNumber(int number)
{
    if (number == 0)
        return string.Empty;
        return number + WriteNumber(number - 1);
   
}
 string result = WriteNumber(b1);
 Console.WriteLine($"N = {b1} {result}");
