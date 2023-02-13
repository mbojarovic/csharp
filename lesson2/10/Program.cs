/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число
 и на выходе показывает вторую цифру этого числа. Через строку решать нельзя.

456 -> 5
782 -> 8
918 -> 1 */
//int randomNumber = ;
int randomNumber = new Random().Next(99,1000);
int rNumber = randomNumber / 10 % 10;
Console.WriteLine($"число {randomNumber} вторую цифру {rNumber}");
