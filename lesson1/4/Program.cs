//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Максимальное из 3 чисел.");

Console.Write("введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine()); //4 //1

Console.Write("введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine()); //2 //8

Console.Write("введите третье число: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine()); //6 //2

int maximum = firstNumber;

if (secondNumber > maximum)
{
    maximum = secondNumber;
}
else
{
    if (thirdNumber > maximum)
    {
        maximum = thirdNumber;
    }
}

Console.WriteLine("максимальное из 3 чисел это - " + maximum);
