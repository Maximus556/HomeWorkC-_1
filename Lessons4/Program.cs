// int Calculate(int a, int b, char sign) // Два числа: a, b; 3 параметр: знак(*; /;)
// {
//     int result = 0;
//     // 'для char-a', "двойные кавычки"
//     if (sign == '*')
//     {
//         result = a * b;
//     }
//     else if (sign == '+')
//     {
//         result = a + b;
//     }
//     else if (sign == '-')
//     {
//         result = a - b;
//     }
//     else
//     {
//         Console.WriteLine("Обработка искл. : такого знака нет");
//     }
//     return result;
// }
// Console.WriteLine(Calculate(1,2, '+'));
// Console.WriteLine(Calculate(3,2, '*'));
// Console.WriteLine(Calculate(100,35, '-'));
// Console.WriteLine(Calculate(100,35, '_'));


// Напишите программу, которая принимает на вход число (А) и 
// выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// // 1. Без метода
// Console.Write("Введите число А: ");
// // limit - искомое число А
// int limit = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// for (int i = 1; i <= limit; i++)
// {
//     sum += i;   //sum = sum + i;
// }
// Console.WriteLine($"Cумма чисел от 1 до {limit} = {sum}");

// Console.Write("Введите число А: ");
// int limit = Convert.ToInt32(Console.ReadLine());
// //PascalCase - для методов, то есть, каждое новое слово начинается с большой буквы
// int GetSum(int A) // A = limit
// {
//     int sum = 0;
//     for (int i = 1; i <= A; i++)
//     {
//         sum += i;   // sum = sum + i;
//     }
//     return sum;
// }
// Console.WriteLine($"Cумма чисел от 1 до {limit} = {GetSum(limit)}");



// Задача 26: Напишите программу, которая принимает на вход число 
// и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// Console.Write("Введите число А: ");
// int A = Convert.ToInt32(Console.ReadLine());
// int count = 0;
// while (A >0)
// {
// A/=10;
// count++;
// }
// Console.WriteLine($" Количество чисел в числе {count}");



// ядз
// System.Console.WriteLine("Введите два числа А и В. Число А будет возведенено в натуральную степень В");
// Boolean cont = true;
// int numberA, numberB, result;
// while (cont)
// {
//     System.Console.WriteLine("Введите значение A: ");
//     numberA = Convert.ToInt32(Console.ReadLine());

//     System.Console.WriteLine("Введите значение B: ");
//     numberB = Convert.ToInt32(Console.ReadLine());

//     result = numberA;

//     for (int i = 2; i <= numberB; i++)
//     {
//         result *= numberA;
//     }

//     System.Console.WriteLine($"Результат выражения A({numberA})^B({numberB}) равен {result}\nПродолжим Yes/No");
//     string next = Console.ReadLine();
//     cont = next.ToLower() == "yes" ? true : false;
// }



// int[] GetBinaryArray(int size)
// {
//     int[] array = new int[size]; // Получается массив на size(8) элементов
//     // Массив состоит из 8 нулей
//     // size = array.Length
//     for (int i = 0; i < size; i++)
//     {
//         // array[i] = new Random().Next(0,2);
//         array[i] = new Random().Next(2); // [0;1]
//         // array[0] = 0, array[1] = 0, array[2] = 0
//     }
//     return array;
// }

// int[] resultArray = GetBinaryArray(8);
// double[] test = new double[10]; 

// for (int i = 0; i < resultArray.Length; i++)
// {
//     Console.Write(resultArray[i] + "\t"); 
// }


// int[] GetBinaryArray(int size)
// {
//     int[] array = new int[size]; //size - 8
//     // Массив состоит из 8 нулей
//     for(int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(2);
//         //array[0] = 1, array[1] = 0 и тп на рандоме
//     }
//     return array;
// }
// int[] resultArray = GetBinaryArray(8);

// // for(int i = 0; i <resultArray.Length; i++)
// // {
// //     Console.Write(resultArray[i] + "\t"); 
// // }
// Console.Write($"Массив: [ {String.Join("; ", resultArray)} ]");


// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// int size = 123;
// int[] array = GetArray(size);
// int[] GetArray(int size)
// {
// int[] rndArray = new int[size];
// for (int i = 0;i < size;i++)
// {
// rndArray[i] = new Random().Next(0, 500);
// }
// return rndArray;}
// int countArray(int[] array, int minValue, int maxValue)
// {
// int sizeArray = array.Length;
// int count = 0;
// for (int i = 0; i < sizeArray; i++)
// { 
// if (array[i] >= minValue && array[i] <= maxValue)
// { 
// count++;
// }
// } 
// return count;
// }
// Console.WriteLine($"Исходный массив: [ {string.Join("; ", array)} ]\n\n");
// Console.WriteLine($"Кол-во элементов: { countArray(array, 10, 99)}");
