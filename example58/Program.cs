// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

using System;
using static System.Console;

Clear();

Write("Введите количество строк 1 массива: ");
int rows1 = int.Parse(ReadLine());
Write("Введите количество столбцов 1 массива: ");
int columns1 = int.Parse(ReadLine());
int[,] array1 = GetArray(rows1, columns1, 0, 5);
Write("Введите количество строк 2 массива: ");
int rows2 = int.Parse(ReadLine());
Write("Введите количество столбцов 2 массива: ");
int columns2 = int.Parse(ReadLine());
int[,] array2 = GetArray(rows2, columns2, 0, 5);
PrintArray(array1);
WriteLine();
PrintArray(array2);
WriteLine();
int[,] array3 = GetArray3(array1, array2);
PrintArray(array3);

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }

    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]} ");
        }
        WriteLine();
    }
}
if (columns1 != rows2)
{
    Write("количество столбцов первой матрицы должно быть равно количеству строк второй матрицы ");
}

int[,] GetArray3(int[,] arr1, int[,] arr2) // умножение матриц
{
    int[,] array3 = new int[arr1.GetLength(0), arr2.GetLength(1)];
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            for (int k = 0; k < arr1.GetLength(1); k++)
            {
                array3[i, j] += arr1[i, k] * arr2[k, j];
            }
        }
    }
    return array3;
}
