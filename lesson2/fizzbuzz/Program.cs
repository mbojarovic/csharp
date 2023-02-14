
/*Задача необязательная FIZZ BUZZ: Напишите программу, которая выводит на экран числа от 1 до 100.
 При этом вместо чисел, кратных трем, программа должна выводить слово Fizz,
  а вместо чисел, кратных пяти — слово Buzz. Если число кратно пятнадцати,
   то программа должна выводить слово FizzBuzz. Задача может показаться очевидной,
    но нужно получить наиболее простое и красивое решение.*/

byte count = 1;
byte end = 100;
string firstName = "Fizz";
string secondName = "Buzz";
while (count <= end)
{
    if (count % 3 == 0)
    {
        Console.Write(firstName);
    }
    if (count % 5 == 0)
        Console.Write(secondName);

    if (count % 3 != 0 & count % 5 != 0)
    {
        Console.Write(count);
    }

    count++;
}

