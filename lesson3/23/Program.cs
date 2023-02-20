/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

int prompt(string message)
{
    Console.Write(message);
    int msg = Convert.ToInt32(Console.ReadLine());
    return msg;
}

int mathPow3(int x)
{
    int result = x * x * x;
    return result;
}
void printNumbers(int userNumber)
{
    int[] kubes = new int[] { };
    for (int i = 1; i <= userNumber; i++)
    {
        Console.Write($"{mathPow3(i)} ");

    }
}

int userNumber = prompt("таблицу кубов чисел от 1 до ");
printNumbers(userNumber);