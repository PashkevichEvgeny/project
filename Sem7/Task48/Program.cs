﻿// Задача 48:
// Задайте двумерный массив размера m на n, каждый элемент
// в массиве находится по формуле: Aₘₙ = m + n. 
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5
System.Console.WriteLine("Введите количество столбцов: ");
int m = int.Parse(Console.ReadLine()!);
int n = int.Parse(Console.ReadLine()!);
int[,] array = new int[m,n];

void FillArray(int m, int n)
{
    for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i,j] = i + j;
    }
}
}
void PrintArray(int[,] array)
{
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        System.Console.Write($"{array[i,j]}");
    }
    System.Console.WriteLine();
}
}
FillArray(m,n);
PrintArray(array);