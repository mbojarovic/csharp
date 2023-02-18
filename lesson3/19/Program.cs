/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
 Через строку решать нельзя.

14212 -> нет
12821 -> да
23432 -> да*/
int prompt(string message)
{
    Console.WriteLine(message);
    int msg = Convert.ToInt32(Console.ReadLine());
    return msg;
}

bool validateNumber(int n)
{
    if (n < 99999 && n > 9999)
    {
        return true;
    }
    else
    {
        return false;
    }
}

bool isPalindrome(int item)
{
    int rev = 0;
    int rem = 0;
    int num = item;

    while (num > 0)
    {
        rem = num % 10;
        rev = rev * 10 + rem;
        num = num / 10;
    }

    if (rev == item)
        return true;
    else
        return false;
}

while (true)
{
    try
    {
        int number = prompt("введите пятизначное число:");

        if (validateNumber(number))
        {
            if (isPalindrome(number))
            {
                Console.WriteLine($"является ли {number} палиндромом -> да");
            }
            else
            {
                Console.WriteLine($"является ли {number} палиндромом -> нет");
            };

            Console.WriteLine("Проверить еще одно число да или нет ?");
            string answer = Console.ReadLine().ToLower();

            if (answer == "да")
                continue;
            else
            {
                break;
            }
        }
        else
        {
            Console.WriteLine("введено ни пятизначное число!");
        }


    }

    catch
    {
        Console.WriteLine("допустимы только цифры");
    }
}


