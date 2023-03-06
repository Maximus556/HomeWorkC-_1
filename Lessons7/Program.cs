﻿// Задача 46: Задайте двумерный массив размером m×n, 
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

// int[,] GetMatrix(int rows, int cols, int minValue, int maxValue)
// {
// int[,] matrix = new int[rows, cols]; // [строчка, столбец]
// for (int i = 0; i < rows; i++) // строчки; rows = matrix.GetLength(0)
// {
// // i,j,m,k - индексы
// for (int j = 0; j < cols; j++)// столбцы; cols = matrix.GetLength(1)
// {
// matrix[i, j] = new Random().Next(minValue, maxValue + 1);
// }
// }
// return matrix; // Вернули заполненную табличку
// }

// void PrintMatrix(int[,] matr) // Печатаем двумерный массив
// {
// for (int i = 0; i < matr.GetLength(0); i++) // проход по строчкам
// {
// for (int m = 0; m < matr.GetLength(1); m++) // Проход по столбцам
// {
// Console.Write(matr[i, m] + "\t"); // "\t" = 4 пробела или tab
// }
// Console.WriteLine();
// }
// }

// // 1. Создать массив
// int[,] resultMatrix = GetMatrix(3,4,0,10);
// // 3 строчки и 4 столбца, числа от 0 до 10 включительно

// // 2. Посмотрим на нашу матрицу
// PrintMatrix(resultMatrix);




// Задача 48: Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

//  тоже самое что и первая задача только вместо рандома применим j+i

// int[,] GetMatrix(int rows, int cols)
// {
// int[,] matrix = new int[rows, cols]; // [строчка, столбец]
// for (int i = 0; i < rows; i++) // строчки; rows = matrix.GetLength(0)
// {
// // i,j,m,k - индексы
// for (int j = 0; j < cols; j++)// столбцы; cols = matrix.GetLength(1)
// {
// matrix[i, j] = i + j;
// }
// }
// return matrix; // Вернули заполненную табличку
// }

// void PrintMatrix(int[,] matr) // Печатаем двумерный массив
// {
// for (int i = 0; i < matr.GetLength(0); i++) // проход по строчкам
// {
// for (int m = 0; m < matr.GetLength(1); m++) // Проход по столбцам
// {
// Console.Write(matr[i, m] + "\t"); // "\t" = 4 пробела или tab
// }
// Console.WriteLine();
// }
// }

// // 1. Создать массив
// int[,] resultMatrix = GetMatrix(3, 4);
// // 3 строчки и 4 столбца, числа от 0 до 10 включительно

// // 2. Посмотрим на нашу матрицу
// PrintMatrix(resultMatrix);







// Задача 49: Задайте двумерный массив. Найдите элементы,
// у которых оба индекса чётные, и замените эти элементы на их квадраты.

// int[,] GetMatrix(int rows, int cols, int minValue, int maxValue)
// {
// int[,] matrix = new int[rows, cols]; // [строчка, столбец]
// for (int i = 0; i < rows; i++) // строчки; rows = matrix.GetLength(0)
// {
// // i,j,m,k - индексы
// for (int j = 0; j < cols; j++)// столбцы; cols = matrix.GetLength(1)
// {
// matrix[i, j] = new Random().Next(minValue, maxValue + 1);
// }
// }
// return matrix; // Вернули заполненную табличку
// }
// int[,] ChangeMatrix(int[,] inputMatrix)
// {
// for (int i = 0; i < inputMatrix.GetLength(0); i++) // строчки
// {
// for (int k = 0; k < inputMatrix.GetLength(1); k++) // столбцы
// {
// if (i % 2 == 0 && k % 2 == 0) // Четные индексы
// {
// inputMatrix[i, k] *= inputMatrix[i, k];
// // inputMatrix[i, k] = inputMatrix[i, k] * inputMatrix[i, k]
// }
// }
// }
// return inputMatrix;
// }
// void PrintMatrix(int[,] matr) // Печатаем двумерный массив
// {
// for (int i = 0; i < matr.GetLength(0); i++) // проход по строчкам
// {
// for (int m = 0; m < matr.GetLength(1); m++) // Проход по столбцам
// {
// Console.Write(matr[i, m] + "\t"); // "\t" = 4 пробела или tab
// }
// Console.WriteLine();
// }
// }
// // 1. Создать массив
// int[,] resultMatrix = GetMatrix(3, 4, 0, 10);
// // 3 строчки и 4 столбца, числа от 0 до 10 включительно
// // 2. Посмотрим на нашу матрицу
// PrintMatrix(resultMatrix);
// Console.WriteLine("Результат: ");
// PrintMatrix(ChangeMatrix(resultMatrix));