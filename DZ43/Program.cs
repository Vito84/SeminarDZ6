/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
int GetNumberFromConsole(string message)
{
    int result = 0;
 
    while (true)
    {
        Console.WriteLine(message);
 
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("ВЫ ввели не число.");
            Console.WriteLine("__________________");
        }
    }
 
    return result;
}
void findingXy (double b1, double b2, double k1, double k2)
{
double x = (b2-b1)/(k1-k2);
double y = k1*x+b1;
Console.WriteLine($"Точка пересечения двух прямых = ({x}; {y})");
}
double b1 = GetNumberFromConsole("Введите значение b1");
double b2 = GetNumberFromConsole("Введите значение b2");
double k1 = GetNumberFromConsole("Введите значение k1");
double k2 = GetNumberFromConsole("Введите значение k2");
findingXy(b1, b2, k1, k2);