/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */
int prompt(string message)
{
    Console.Write(message);
    int userNumber = Convert.ToInt32(Console.ReadLine());
    return userNumber;
}

int[] lenghtNumber(int numbers)
{
    int[] lNumbers = new int[numbers];
    for (int i = 0; i < numbers; i++)
    {
        lNumbers[i] = prompt($"числo {i + 1} - ");
    }
    return lNumbers;
}

int CountNumber(int[] arrayNumber)
{
    int count = 0;
    foreach (int elements in arrayNumber)
    {
        if (elements > 0)
        {
            count++;
        }
    }
    return count;
}

int number = prompt("вводит с клавиатуры «количество» чисел - ");
int[] numbers = lenghtNumber(number);
int res = CountNumber(numbers);
Console.WriteLine($"больше нуля {res}"); //отладка
