// Задача 39: Напишите программу, которая перевернёт 
// одномерный массив (последний элемент будет на первом месте, 
// а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] array = FillArray(10, 0, 10); // Массив на 10 элементов,
// заполненный рандомными числами от 0 до 10 включительно
// Console.WriteLine($"Текст:{переменная} текст");
Console.WriteLine($"Исходный массив:  [{String.Join("; ", array)}]");
// FillArray: размер, мин, макс
int[] FillArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}
// // Запись массива в обратном порядке в новый массив
// int[] resultArray = CopyArray(array);
// Console.WriteLine("Переворот через не VOID");
// Console.WriteLine($"Перевернутый массив:  [{String.Join("; ", resultArray)}]");
// int[] CopyArray(int[] inputArray)
// {
//     int size = inputArray.Length;
//     int j = size - 1; // Индекс последнего элемента
//     int[] inverseArray = new int[size]; // Массив на size элементов, заполне нулями
//     for (int i = 0;  i < size; i++, j--)
//     {
//         // inverseArray[i] = inputArray[size - 1 - i];
//         inverseArray[i] = inputArray[j];
//     }
//     return inverseArray;
// }

// // С помощью доп. переменной
// void ReverseArray(int[] arr)
// {
//     // a = {10,20,30,40,50}
//     for (int i = 0; i < arr.Length / 2; i++)
//     {
//         int temp = arr[i]; // temp = arr[0] = 10
//         arr[i] = arr[arr.Length - 1 - i]; // a[0] = a[5 - 1 - 0] 
//         // a = {50,20,30,40,50}
//         arr[arr.Length - 1 - i] = temp;
//         // a = {50,20,30,40,temp}, a = {50,20,30,40,10}
//     }
// }
// Console.WriteLine("Переворот через метод VOID");
// ReverseArray(array); // Здесь массив исходный с именем array перевернулся
// Console.WriteLine($"Перевернутый массив:  [{String.Join("; ", array)}]");


// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника 
// меньше суммы двух других сторон.

// СПОСОБ 1-ый
// Console.WriteLine("Введите сторону a: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите сторону b: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите сторону c: ");
// int c = Convert.ToInt32(Console.ReadLine());

// string CheckSum(int a, int b, int c)
// {
//     if (a + b > c && b + c > a && a + c > b)
//     {
//         return "Треугольник существует";
//     }
//     else
//     {
//         return "Треугольник НЕ существует";
//     }
// }

// // System.Console.WriteLine(CheckSum(value1, value2, value3));

// System.Console.WriteLine((a + b > c && b + c > a && a + c > b) ? "Треугольник существует" : "Треугольник НЕ существует");

// СПОСОБ 2-ОЙ
// int a = 35;

// int b = 4;

// int c = 5;

// bool IsTrinagle(int a, int b, int c)
// {
//     return (a + b > c && a + c > b && b + c > a); // False - треугольник не существует, True - существует
// }

// Console.WriteLine(IsTrinagle(a,b,c));




// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


// int countFibonacci = 5;
// int firstFibonacci = 0; // Первое число Фибоначчи
// int secondFibonacci = 1; // Второе число Фибоначчи
// Console.WriteLine($"1. {firstFibonacci}"); // i = 1
// Console.WriteLine($"2. {secondFibonacci}"); // i = 2
// for (int i = 3; i <= countFibonacci; i++)
// {
// int nextFibonacci = firstFibonacci + secondFibonacci;
// Console.WriteLine($"{i}. {nextFibonacci}");
// firstFibonacci = secondFibonacci;
// secondFibonacci = nextFibonacci;
// }

