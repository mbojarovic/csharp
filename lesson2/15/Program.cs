/*Задача 15: Напишите программу, которая принимает на вход цифру,
 обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/
Console.WriteLine("Напишите цифру, обозначающую день недели, является ли этот день выходным.????");
int userNumber = Convert.ToInt32(Console.ReadLine());
switch (userNumber) {

    case 1 or 2 or 3 or 4 or 5:
    Console.WriteLine("нет");
    break;

    case 6 or 7:
    Console.WriteLine("да");
    break;

    default:
        Console.WriteLine("неверно введенный день недели");
        break;
}
