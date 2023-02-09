string randomNumber = new Random().Next(1, 10).ToString();
Console.WriteLine("угадайте число от 1 до 10 ");
while (true) {
    Console.Write("напишите число: ");
    string userNumber = Console.ReadLine();

    if (randomNumber == userNumber) {
        Console.WriteLine("Вы угадали!!!");
        Console.WriteLine("хотите сыграть заново? напишите да или нет.");
        string userAnswer = Console.ReadLine();

        if (userAnswer.ToLower() == "да") {
            continue;
        } else {
            break;
        }

    } else {
        Console.WriteLine("вы не угадали!!!");
    }
}
