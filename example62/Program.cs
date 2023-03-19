// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


using System;
using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine());
Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine());
int[,] array = GetArray(rows, columns);
PrintArray(array);
WriteLine();

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = 0;
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

int[,] Fill(int x, int y)
{
    int[,] result = new int[array.GetLength(0), array.GetLength(1)];
    while ( array[x, y] <= array.GetLength(0) * array.GetLength(1) && x < array.GetLength(1) && y < array.GetLength(0) && x >= 0 && y >= 0 )
    {
        if (array[x, y] == 0)
        {   
            array[x, y]++;
            Fill(x, y + 1);
            Fill(x + 1, y);
            Fill(x, y - 1);
            Fill(x - 1, y);
        }
    }
    return result;
}
int[,] array1 =Fill(0, 0);
PrintArray(array1);
