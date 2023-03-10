// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


// int[,] resultMatrix = GetMatrix(3, 4, 0, 10);
// Console.WriteLine("Исходный двумерный массив");
// PrintMatrix(resultMatrix);

// /// <summary>
// /// Генерация двумерного массива из целых рандомных чисел
// /// </summary>
// /// <param name="rows"> Кол-во строк в массиве </param>
// /// <param name="cols"> Кол-во столбцов в массиве </param>
// /// <param name="minValue">Минимальное число в массиве</param>
// /// <param name="maxValue">Максимальное число в массиве</param>
// /// <returns>
// /// Заполненный двумерный массив целых чисел
// /// </returns>

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

// /// <summary>
// /// Функция печатает двумерный массив
// /// </summary>
// /// <param name="matr">Двумерный массив</param>

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

// // цикл упорядочевыния элементов массива в строках
// for (int i = 0; i < resultMatrix.GetLength(0); i++)
// {
//     for (int j = 0; j < resultMatrix.GetLength(1) - 1; j++)
//     {
//         for (int k = 0; k < resultMatrix.GetLength(1) - 1; k++)
//         {
//             if (resultMatrix[i, k] < resultMatrix[i, k + 1]) 
//             {
//                 int temp = 0;
//                 temp = resultMatrix[i, k];
//                 resultMatrix[i, k] = resultMatrix[i, k + 1];
//                 resultMatrix[i, k + 1] = temp;
//             }
//         }
//     }
// }
// Console.WriteLine("Упорядоченный двумерный массив");
// PrintMatrix (resultMatrix);



// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int[,] resultMatrix = GetMatrix(3, 4, 0, 10);
// Console.WriteLine("Исходный двумерный массив");
// PrintMatrix(resultMatrix);
// int minSum = int.MaxValue;
// int indexLine = 0;

// // Нахождение номера строки с наименьшой суммой элементов
// for (int i = 0; i < resultMatrix.GetLength(0); i++)
// {
//     int sum = 0;
//     for (int j = 0; j < resultMatrix.GetLength(1); j++)
//     {
//         sum = sum + resultMatrix[i, j];
//     }
//     if (sum < minSum)
//     {
//         minSum = sum;
//         indexLine++;
//     }
// }
// Console.WriteLine($"Номер строки с наименьшой суммой элементов:  {indexLine}");

// /// <summary>
// /// Генерация двумерного массива из целых рандомных чисел
// /// </summary>
// /// <param name="rows"> Кол-во строк в массиве </param>
// /// <param name="cols"> Кол-во столбцов в массиве </param>
// /// <param name="minValue">Минимальное число в массиве</param>
// /// <param name="maxValue">Максимальное число в массиве</param>
// /// <returns>
// /// Заполненный двумерный массив целых чисел
// /// </returns>

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

// /// <summary>
// /// Функция печатает двумерный массив
// /// </summary>
// /// <param name="matr">Двумерный массив</param>

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


// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int[,] firstMartrix = GetMatrix(2, 2, 0, 10);
// Console.WriteLine($"Первая матрица:");
// PrintMatrix(firstMartrix);

// int[,] secomdMartrix = GetMatrix(2, 2, 0, 10);
// Console.WriteLine($"Вторая матрица:");
// PrintMatrix(secomdMartrix);


// int[,] resultMatrix = new int[2, 2]; // Не получилось привести к методу, 
//                                     // приходится указывать параметры массива заблаговременно
//                                     // хотел применить метод MultiplicationMatrix 
//                                     // передав параметры firstMartrix, secomdMartrix, resultMatrix;



// for (int i = 0; i < resultMatrix.GetLength(0); i++)
// {
//     for (int j = 0; j < resultMatrix.GetLength(1); j++)
//     {
//         int sum = 0;
//         for (int k = 0; k < firstMartrix.GetLength(1); k++)
//         {
//             sum += firstMartrix[i, k] * secomdMartrix[k, j];
//         }
//         resultMatrix[i, j] = sum;
//     }
// }
// Console.WriteLine($"Произведение первой и второй матрицы :");
// PrintMatrix(resultMatrix);


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




// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


// int[,,] resultMatrix = GetMatrix(2, 2, 2, 0, 50);
// Console.WriteLine("Построчный массив с индексами элементов:");
// PrintMatrix(resultMatrix);


// /// <summary>
// /// Метод создания трехмерного массива
// /// </summary>
// /// <param name="rows"> Кол-во строк в массиве</param>
// /// <param name="cols">Кол-во столбцов в массиве</param>
// /// <param name="depth"> Глубина массива</param>
// /// <param name="minValue">Минимальное число в массиве</param>
// /// <param name="maxValue">Максимальное число в массиве</param>
// /// <returns>
// /// Возвращает заполненный рандомными числами трехмерный массив
// /// </returns>
// int[,,] GetMatrix(int rows, int cols, int depth, int minValue, int maxValue)
// {
//     int[,,] matrix = new int[rows, cols, depth];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrix.GetLength(2); k++)
//             {
//                 matrix[i, j, k] = new Random().Next(minValue, maxValue + 1);
//             }
//         }
//     }
//     return matrix;
// }


// /// <summary>
// /// Функция печати индексов элемента трехмерного массива
// /// </summary>
// /// <param name="matr">Исходный трехмерный массив</param>
// void PrintMatrix(int[,,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int m = 0; m < matr.GetLength(1); m++)
//         {
//             Console.WriteLine();
//             for (int n = 0; n < matr.GetLength(2); n++)
//             {
//                 Console.Write($"{matr[i, m, n]}({i},{m},{n}) ");;
//             }
//             Console.WriteLine();
//         }
//     }
// }

