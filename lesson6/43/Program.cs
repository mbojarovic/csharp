/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

int Input(string message) {
    Console.WriteLine(message);
    int msg = Convert.ToInt32(Console.ReadLine());
    return msg;
}
int b1 = Input("значения b1");
int k1 = Input("значения k1");
int b2 = Input("значения b2");
int k2 = Input("значения b2");

void check(int b1, int k1, int b2, int k2) {
    double x = -b1 - b2 / k1 - k2;
    double y = k1 * x + b1;
    Console.Write($"\n Точка пересечения двух прямых: {x},{y}");
}
check(b1,k1,b2,k2);
