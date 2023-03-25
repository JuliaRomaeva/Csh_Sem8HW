// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


// using System;
// using static System.Console;

// Clear();

// Write("Введите размер массива: ");
// int N = int.Parse(ReadLine());
// // Write("Введите количество столбцов массива: ");
// // int columns = int.Parse(ReadLine());
// int[,] array = GetArray(N);
// PrintArray(array);
// WriteLine();

// int[,] GetArray(int n)
// {
//     int[,] result = new int[n, n];
//     int num = 1;
//     for (int j = 0; j < n; j++)
//     {
//         {
//             result[0, j] = num;
//             num++;
//         }
//         for (int i = 1; i < n; i++)
//         {
//             result[i, n - 1] = num;
//             num++;
//         }
//         for (int i = n - 1; i >= 0; i--)
//         {
//                 result[n - 1, i] = num;
//                 num++;
//         }
//         for (int i = n - 1; i >= 0; i--)
//         {
//                 result[i, 0] = num;
//                 num++;
//         }  
//     }
//     return result;
// }   
//     void PrintArray(int[,] inArray)
//     {
//         for (int i = 0; i < inArray.GetLength(0); i++)
//         {
//             for (int j = 0; j < inArray.GetLength(1); j++)
//             {
//                 Write($"{inArray[i, j]} ");
//             }
//             WriteLine();
//         }
//     }



Console.Clear();
Console.WriteLine($"Задача 62: Заполните спирально массив 4 на 4.");

int n = 4;
int[,] sqareMatrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
{
  sqareMatrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

WriteArray(sqareMatrix);

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}


// int[,] Fill(int x, int y)
// {
//     int[,] result = new int[array.GetLength(0), array.GetLength(1)];
//     while ( array[x, y] <= array.GetLength(0) * array.GetLength(1) && x < array.GetLength(1) && y < array.GetLength(0) && x >= 0 && y >= 0 )
//     {
//         if (array[x, y] == 0)
//         {   
//             array[x, y]++;
//             Fill(x, y + 1);
//             Fill(x + 1, y);
//             Fill(x, y - 1);
//             Fill(x - 1, y);
//         }
//     }
//     return result;
// }
// int[,] array1 =Fill(0, 0);
// PrintArray(array1);
