/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

int numberA(string message)
{
    Console.WriteLine(message);
    int numberA = Convert.ToInt32(Console.ReadLine());
    return numberA;
}
int numberB(string message)
{
    Console.WriteLine(message);
    int numberA = Convert.ToInt32(Console.ReadLine());
    return numberA;
}

int mathPow(int a, int b)
{
    int result = 1;
    for (int i = 0; i < b; i++)
    {
        result = result * a;
    }
    return result;
}

void print (int a, int b, int res) {
    Console.WriteLine($"числа {a} и {b} -> {res}");
}
void run()
{
    int a = numberA("число первое");
    int b = numberB("число второе");
    int result = mathPow(a, b);
    print (a , b , result);
}

run();



