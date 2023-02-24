// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int prompt(string message) {
   Console.WriteLine(message);
   int userNumber = Convert.ToInt32(Console.ReadLine());
   return userNumber;
}
int sumNumber(int number) {
    int sNumber = 0;
    while (0 < number) {
        sNumber += number % 10;
        number = number / 10;
    }
    return sNumber;
}
int number = prompt("напишите число");
int result = sumNumber(number);
Console.WriteLine(result);