﻿// Задача 21:
// Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4
using static System.Console;
Clear();

Write("Введите положительное число: ");
int N = int.Parse(ReadLine()!);
int count;

// Вывод кубов через запятую
count = 1;
while (count < N)
{
    Write($"{count * count}, ");
    count++;
}
WriteLine(count * count);