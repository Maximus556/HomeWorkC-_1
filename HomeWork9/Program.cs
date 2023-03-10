// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());

// string PrintNumbers(int start)
// {
//     // Базовый
//     if (start == 1) return start.ToString();
//     // Рекурсивный
//     return (start + "," + PrintNumbers(start - 1));
// }

// Console.WriteLine($"Натуральные числа от {N} до 1:          {PrintNumbers(N)}");

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.Write("Введите число M: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число N: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());

// int SumNumbers(int firstNumber, int secondNumber)
// {
//     int sum = 0;
//     // Базовый случай - случай выхода из рекурсии
//     if (firstNumber == secondNumber) return sum = +secondNumber;
//     // Рекурсивный случай - задание рекурсии (вызов функции внутри функции)
//     return (sum = (firstNumber + SumNumbers(firstNumber + 1, secondNumber)));
// }

// Console.WriteLine($"Cумма натуральных элементов в промежутке от {firstNumber} до {secondNumber}: \t {SumNumbers(firstNumber, secondNumber)}");



// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int AkkermanFunction(int m, int n)
// {
//     if (m == 0) return n + 1;
//     if (m != 0 && n == 0) return AkkermanFunction(m - 1, 1);
//     if (m > 0 && n > 0) return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
//     return AkkermanFunction(m, n);
// }

// Console.WriteLine($"Функция Аккермана для чисел {m} и {n} = {AkkermanFunction(m, n)}");