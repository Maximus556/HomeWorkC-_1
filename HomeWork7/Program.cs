// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// double[,] GetMatrix(int rows, int cols, double minValue, double maxValue)
// {
//     double[,] matrix = new double[rows, cols];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = Math.Round(10 * (new Random().NextDouble()), 2);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(double[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int m = 0; m < matr.GetLength(1); m++)
//         {
//             Console.Write(matr[i, m] + "\t");
//         }
//         Console.WriteLine();
//     }
// }

// double[,] resultMatrix = GetMatrix(3, 4, 0, 10);
// PrintMatrix(resultMatrix);



// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Console.Write("введите номер строки");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите номер столбца");
// int cols = Convert.ToInt32(Console.ReadLine());

// int[,] GetMatrix(int rows, int cols, int minValue, int maxValue)
// {
//     int[,] matrix = new int[rows, cols];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int m = 0; m < matr.GetLength(1); m++)
//         {
//             Console.Write(matr[i, m] + "\t");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] resultMatrix = GetMatrix(3, 4, 0, 10);
// if (rows < resultMatrix.GetLength(0) && cols < resultMatrix.GetLength(1))
// {
//     Console.WriteLine($"Элемент по строке {rows} и столбцу {cols} в массиве равен: {resultMatrix[rows, cols]}");
// }
// else
// {
//     Console.WriteLine($"Элемента по строке{rows} и столбцу {cols} в массиве нет");
// }

// PrintMatrix(resultMatrix);






// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// int[,] GetMatrix(int rows, int cols, int minValue, int maxValue)
// {
//     int[,] matrix = new int[rows, cols];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int m = 0; m < matr.GetLength(1); m++)
//         {
//             Console.Write(matr[i, m] + "\t");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] resultMatrix = GetMatrix(3, 4, 0, 10);
// Console.WriteLine();
// PrintMatrix(resultMatrix);
// Console.WriteLine("---------------------------");
// for (int j = 0; j < resultMatrix.GetLength(1); j++)
// {
//     double avarage = 0;
//     for (int i = 0; i < resultMatrix.GetLength(0); i++)
//     {
//         avarage = (avarage + resultMatrix[i, j]);
//     }
//     avarage = Math.Round(avarage / resultMatrix.GetLength(0), 2);
//     Console.Write(avarage + "; " + "\t");
// }
