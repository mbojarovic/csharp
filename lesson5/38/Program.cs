/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */

int[] CreateArray(int value)
{
    int[] array = new int[value];
    return array;
}

int RandomDigits()
{
    int randomDigits = new Random().Next(3,100);
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

int findMax (int[] array) {
    int max = array.Length;
    foreach (int element in array)
    {
        if (element > max)
        {
            max = element;
        }
    }
    return max;
}

int findMin (int[] array) {
    int min = array.Length;
    foreach (int element in array)
    {
        if (element < min)
        {
            min = element;
        }
    }
    return min;
}

int DiferenceMinMax (int min, int max) {
    int result = max - min;
    return result;
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
PrintArray(numberArray);
int max = findMax(newArray);
int min = findMin(newArray);
int result = DiferenceMinMax(min, max);
Console.WriteLine("->   разницу между максимальным и минимальным элементов массива " + result);
