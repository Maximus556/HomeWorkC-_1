
//ОПЕРАТОРЫ
// Унарные операторы - 1 операнд
// а+

// Бинарные операторы -2 операнда
// b*a

// Постфиксной: "после" а++

// Префиксный оператор: "перед" ++а


// int a = 1;

// int prefixIncrement = ++a * a;

// Console.WriteLine(prefixIncrement); // Наибольший приоритет

// int b = 1; 
// int postfixIncrement = b++ * b; // наименьший приоритет
// Console.WriteLine(postfixIncrement);


// Тернарный оператор условие ? trye : false
// условие - 1 операнд ? значение для истины - 2 : значение для лжи - 3

// int dreamSalary = int.MaxValue;

// int realSalary = 50000;

// var result = realSalary < dreamSalary ? "Пока что ЗП не такая большая" : "Наша зарплата: 2147483647";

// Console.WriteLine(result);



// Рекурсия - задаем выход и по ом само решение
// int Factorial (int n)
// {
//     // Базовый случай - случай выхода из рекурсии
//     if (n == 1) return 1; // Факториал от 1 = 1
//     // Рекурсивный случай - задание рекурсии (вызов функции внутри функции)
//     return n * Factorial(n - 1);
// }

// Console.WriteLine(Factorial(4)); // 4*3*2*1 = 24


// Задача 63: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
/// <summary>
/// Печатаем все натуральные числа в промежутке от 1 до N.
/// </summary>
/// <param name="start"> 1 = start</param>
/// <param name="end"> N = end</param>
/// <returns></returns>
string PrintNumbers(int start, int end)
{
    // Базовый
    if (start == end) return start.ToString();
    // Рекурсивный
    return (start + "," + PrintNumbers(start + 1, end));
}

Console.WriteLine(PrintNumbers(1, N));


// Задача 67: Напишите программу, которая будет принимать на вход число 
// и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int SumNumbers(int num)
// {
//     // Базовый
//     if (num == 0) return 0; // К результату добавляется 0
//     // Рекурсивный случай
//     return (num % 10 + SumNumbers(num / 10));
// }

// Console.WriteLine(SumNumbers(number));


// Задача 69: Напишите программу, которая на вход принимает два числа A и B,
//  и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите степень: ");
// int power = Convert.ToInt32(Console.ReadLine());

// int GetPower(int number, int power)
// {
//     // Базовый случай
//     if(power == 0) return 1; // Число в 0 степнени = 1
//     if(power == 1) return number;// Число в первой степени = число
//     // Рекурсивный
//     return (number * GetPower(number, power - 1));
// }
// Console.WriteLine(GetPower (number, power));




// ДЗ

// задача 66 как факториал
