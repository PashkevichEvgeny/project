﻿// Задача 67:
// Напишите программу работающую рекурсивно, 
// которая будет принимать на вход число и возвращать сумму его цифр.
// 605  ->  6 + 0 + 5 = 11

int count = 1;
int SumDigit(int n)
{
    System.Console.WriteLine($"Вызов №{count++} в стеке лежит: {n % 10}");
    if (n < 10) return n;
    // Кладем в стек остаток от деления и вызываем функцию с числом обрезанным на один разряд
    return n % 10 + SumDigit(n / 10);
}

System.Console.WriteLine(SumDigit(12345));