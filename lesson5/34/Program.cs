/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */

int[] CreateArray(int value)
{
    int[] array = new int[value];
    return array;
}

int RandomDigits()
{
    int randomDigits = new Random().Next(100, 999);
    return randomDigits;
}

int[] FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = RandomDigits();
    }
    return array;
}

void EvenNumbers(int[] array)
{
    int count = 0;

    foreach (int element in array)
    {
        if (element % 2 == 0)
        {
            count++;
            Console.Write(element + "" + "->" + " " + count);
        }
    }
}

void PrintArray(int[] array)
{
    foreach (int element in array)
    {
        Console.Write(element + "\t");
    }
}

int[] numberArray = CreateArray(4);
int[] newArray = FillArray(numberArray);
PrintArray(newArray);
Console.WriteLine("\n");
EvenNumbers(newArray);