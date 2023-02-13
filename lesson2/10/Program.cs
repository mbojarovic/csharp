/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число
 и на выходе показывает вторую цифру этого числа. Через строку решать нельзя.

456 -> 5
782 -> 8
918 -> 1 */
//int randomNumber = ;
byte randomNumber = new Random().Next(99,1000);
byte rNumber = randomNumber / 10 % 10;
Console.WriteLine($"число {randomNumber} вторую цифру -{rNumber}");
