//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет
Console.Write("введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int number = userNumber % 2;
if (number == 0) {
    Console.Write("четное число");
} else {
    Console.Write("нечетное число");
}