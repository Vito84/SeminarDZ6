/* 
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
 
Console.WriteLine("Введите цифры через пробел");
string numbers = Console.ReadLine() ?? "NULL";
int[] arrNumbers = numbers.Split(' ').Select(Int32.Parse).ToArray();
int sum = 0;
for (int i = 0; i < arrNumbers.Length; i++)
{
    if (arrNumbers[i] > 0)
    {
        sum++;
    }
}
Console.WriteLine($"Количество чисел больше 0 {sum}");