/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

int InputNum(string message) //ввод параметров
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}


int number = InputNum("Введите количество чисел: ");
int temp = 0;
int sumPositive = 0;
for (int i = 0; i < number; i++)
{
    temp = InputNum("Введите число: ");
    if (temp > 0) sumPositive++;
}
Console.Write(sumPositive);



/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/


