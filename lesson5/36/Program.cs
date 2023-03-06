/* Задача 36: Задайте одномерный массив, заполненный случайными числами.
 Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

int[] CreateArray(int value)
{
    int[] array = new int[value];
    return array;
}

int RandomDigits()
{
    int randomDigits = new Random().Next(1, 10);
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

void EvenNumbersSum(int[] array)
{
    int sum = 0;
    foreach (int element in array)
    {
        if (element % 2 !=0 )
        {
            sum = sum + element;
        }
    }
    PrintArray(array);
    Console.WriteLine("->" + "\t" + sum);
}

void PrintArray(int[] array)
{
    foreach (int element in array)
    {
        Console.Write(element + " \t");
    }
}


int[] numberArray = CreateArray(RandomDigits());
int[] newArray = FillArray(numberArray);
Console.WriteLine("\n");
EvenNumbersSum(newArray);