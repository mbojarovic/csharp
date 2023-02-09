string randomNumber = new Random().Next(1, 10).ToString();
Console.WriteLine("угадайте число от 1 до 10 ");
while (true) {
    Console.Write("напишите число: ");
    string userNumber = Console.ReadLine();

    if (randomNumber == userNumber) {
        Console.WriteLine("Вы угадали!!!");
        Console.WriteLine("хотите сыграть заново? да или нет");
        string userAnswer = Console.ReadLine();

        if (userAnswer == "да") {
            continue;
        } else if (userAnswer == "нет") {
            break;
            } else {
            Console.WriteLine("eeeeeeee");
        }

    } else {
        Console.WriteLine("вы не угадали!!!");
    }
}
