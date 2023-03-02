// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество 
// чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] array = GetArray(5, 100, 999);
// int size = array.Length;
// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < result.Length; i++)
//     {
//         result[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return result;
// }
// Console.WriteLine($"Исходный массив: [{String.Join("; ", array)}]");
// int count = 0; // Количество четных чисел в массиве
// for (int i = 0; i < size; i++)
// {
//     if (array[i] % 2 == 0)
//     {
//         count++;
//     }
// }
// Console.WriteLine($"Количество четных чисел в массиве: {count}");



// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


// int result = 0;
// int size = 4;
// int[] array = new int[size];
// for (int i = 0; i < size; i++)
// {
//     array[i] = new Random().Next(-10, 10);
// }
// for (int i = 1; i < size; i += 2)
// {
//         result += array[i];
// }

// Console.WriteLine($"Исходный массив: [{String.Join("; ", array)}]");
// Console.WriteLine($"Сумма элементов на нечетных позициях = {result}");



// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
int size = 5;
double[] array = new double[size];
{
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(100 * (new Random().NextDouble()), 2);
    }
}
Console.WriteLine($"Исходный массив: [{String.Join("; ", array)}]");
for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(array[i],0);
    }
double max = array[0];
double min = array[0];
for (int i = 0; i < size; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    if (array[i] < min)
    {
        min = array[i];
    }
}
 for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(array[i],0);
    }
Console.WriteLine($"Округленный массив: [{String.Join("; ", array)}]");
Console.WriteLine($"Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементов массива: {Math.Round(max, 0) - Math.Round(min, 0)}");