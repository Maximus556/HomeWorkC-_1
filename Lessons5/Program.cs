// int[] array = GetArray(12, -9, 9);

// // Создание массива
// // 3 параметра: 1 параметр - размер массива size
// // 2 параметр: нижняя граница рандома (-9), верхняя граница рандома (9) 
// int[] GetArray(int size, int minValue, int maxValue)
// {
// int[] result = new int[size]; // Создание массива на size элементов
// // Если size = 12, то массив состоит из 12 нулей
// for (int i = 0; i < result.Length; i++) // result.Length = size
// {
// result[i] = new Random().Next(minValue, maxValue + 1);
// }
// return result; // Вернули массив на size элементов, заполненный числами
// // от minValue до maxValue
// }

// int[] InverseArray(int[] inputArray)
// {
// for (int i = 0; i < inputArray.Length; i++)
// {
// inputArray[i] *= (-1); // inputArray[i] = inputArray[i] * (-1)
// }
// return inputArray;
// }
// Console.WriteLine($"Исходный массив: [{String.Join("; ", array)}]");
// Console.WriteLine($"Перевернутый массив:: [{String.Join("; ", InverseArray(array))}]");






// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

// int[] array = GetArray(5, -10, 10);
// int size = array.Length;
// int number = Convert.ToInt32(Console.ReadLine());
// // int maxValue=Convert.ToInt32(Console.ReadLine());
// // int minValue=Convert.ToInt32(Console.ReadLine());
// int[] GetArray(int size, int minValue, int maxValue)
// {
// int[] result = new int[size]; // Создание массива на size элементов
// // Если size = 12, то массив состоит из 12 нулей
// for (int i = 0; i < result.Length; i++) // result.Length = size
// {
// result[i] = new Random().Next(minValue, maxValue + 1);
// }
// return result;
// } 
// bool isMatch = false;
// for (int i = 0; i < size; i++)
// {
// if (number == array[i])
// {
// isMatch = true;

// break;
// }
// }
// Console.WriteLine(String.Join(";", array));
// if (isMatch==true)
// {
// Console.WriteLine("Число найдено");
// }
// else
// {
// Console.WriteLine("Число не найдено");
// }
