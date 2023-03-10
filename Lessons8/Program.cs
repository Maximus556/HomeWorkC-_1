// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет 
// местами первую и последнюю строку массива.




// // 1. Заполним таблицу
// int[,] resultMatrix = GetMatrix(3, 3, 0, 10); //3 стр, 3 стлбц, числа от 0 до 10 включительно
// // Квадратная матрица: строки = столбцы(5 = 5)

// // 2. Печать матрицы
// PrintMatrix(resultMatrix);

// // Меняем 1 и последнюю строчку местами
// Console.WriteLine("Результирующая матрица: ");
// ChangeRows(resultMatrix);
// PrintMatrix(resultMatrix); // Печатает матрицу с замененной 1 и последней строчкой

// /// <summary>
// /// Этот метод заполняет двумерный массив
// /// числами от min до max (общее описание)
// /// </summary>
// /// <param name="rows">Количество строк (описывается параметр)</param>
// /// <param name="cols">Количество столбцов (описывается параметр)</param>
// /// <param name="min">Минимальное число для рандома(описывается параметр)</param>
// /// <param name="max">Максимальное число для рандома(описывается параметр)</param>
// /// <returns>Заполненный двумерный массив целых чисел</returns>
// int[,] GetMatrix(int rows, int cols, int min, int max) // параметры (4) 
// {
//     int[,] matrix = new int[rows, cols];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             matrix[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return matrix;
// }
// /// <summary>
// /// Метод печатает матрицу, которую передали на вход
// /// </summary>
// /// <param name="inputMatrix"> Двумерный массив или таблица </param>
// void PrintMatrix(int[,] inputMatrix)
// {
//     for (int i = 0; i < inputMatrix.GetLength(0); i++) // Строчки
//     {
//         for (int j = 0; j < inputMatrix.GetLength(1); j++) // Столбцы
//         {
//             Console.Write(inputMatrix[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }
// // Методы: PascalCase (FillArray, FillMatrix)
// // camelCase (firstNumber, inputMatrix)
// /// <summary>
// /// Метод меняет 1 и последнюю строчку местами
// /// </summary>
// /// <param name="matr"> матрица (двумерный массив) </param>
// void ChangeRows(int[,] matr)
// {
//     int lastRow = matr.GetLength(0) - 1; // Индекс самой последней строчки :Р
//     for (int i = 0; i < matr.GetLength(1); i++)
//     {
//         int temp = matr[0, i]; // Элемент таблицы из 0 строчки и i столбца
//         matr[0, i] = matr[lastRow, i];
//         //  Элемент из 0 строчки и i столбца = элементу из посл. строчки и i столбца
//         matr[lastRow, i] = temp; 
//         // элемент из посл. строчки и i столбца = temp = Элемент таблицы из 0 строчки и i столбца
//     }
// }

// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.


int rows = 3;
int columns = 3;
if (rows != columns) // Проверка на неравенство
{
    Console.WriteLine("Матрица прямоугольная");
    return;
}
// 1. Заполним таблицу
int[,] resultMatrix = GetMatrix(rows, columns, 0, 10); //3 стр, 3 стлбц, числа от 0 до 10 включительно
// Квадратная матрица: строки = столбцы(5 = 5)
PrintMatrix(resultMatrix);
// 2. Печать матрицы
Console.WriteLine("Результат: ");
PrintMatrix(ChangeArray(resultMatrix));

int[,] GetMatrix(int rows, int cols, int min, int max) // параметры (4)
{
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}
/// <summary>т
/// Метод печатает матрицу, которую передали на вход
/// </summary>
/// <param name="inputMatrix"> Двумерный массив или таблица </param>
void PrintMatrix(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++) // Строчки
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++) // Столбцы
        {
            Console.Write(inputMatrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] ChangeArray(int[,] matrix) // параметры (4)
{
    int[,] copyMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < copyMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < copyMatrix.GetLength(1); j++)
        {
            copyMatrix[i, j] = matrix[j, i];
        }
    }
    return copyMatrix;
}





int rows = 3;

int cols = 3;

int[,] matrix = new int[rows, cols];

int min = int.MaxValue;

int indexMinRows = 0; // Номер строчки с мин. элементом
int indexMinCols = 0; // Номер строчки с мин. элементом

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        matrix[i,j] = new Random().Next(11); // 0-10
        Console.Write(matrix[i,j] + "\t");
        if (min > matrix[i,j])
        {
            min = matrix[i,j];
            indexMinRows = i;
            indexMinCols = j;
        }
    }
    Console.WriteLine();
}
Console.WriteLine($"Мин.элемент: {min}, \t строчка: {indexMinRows}, \t cтолб: {indexMinCols}");

for (int i = 0; i < rows; i++)
{
    if(i != indexMinRows)
    {
        for (int j = 0; j < cols; j++)
        {
            if (j != indexMinCols)
            {
                Console.Write(matrix[i,j] + "\t");
            }
        }
        Console.WriteLine();
    }
}