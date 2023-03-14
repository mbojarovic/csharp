/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

int Input(string message)
{
    Console.WriteLine(message);
    int msg = Convert.ToInt32(Console.ReadLine());
    return msg;
}
int a = Input("значения M");
int b = Input("значения N");

int WriteNumber(int numberM, int numberN)
{
   
    if (numberM == numberN +1) {
        return 0;
        } else {
           return numberM + WriteNumber(numberM +1, numberN); 
        }
   
}
 int result = WriteNumber(a, b);
 Console.WriteLine($"N = {b} {result}");