// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


// // A(x1; y1; z1)
// Console.Write("Введите координату точки A по оси Х: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату точки  A по оси Y: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату точки  A по оси Z: ");
// int z1 = Convert.ToInt32(Console.ReadLine());

// // B(x2; y2; z2)
// Console.Write("Введите координату точки B по оси Х: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату точки B по оси Y: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату точки B по оси Z: ");
// int z2 = Convert.ToInt32(Console.ReadLine());


// var result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)+ Math.Pow(z2 - z1, 2));
// Console.WriteLine($"Результат: {Math.Round(result, 2)}"); 


// Задача 23
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// // for(начало; условие; увеличение переменной - счетчика)
// for(int i = 1; i <= N; i++)
// {
//     Console.WriteLine(Math.Pow(i, 3));
// }

// Задача 19
// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


// Console.Write("Введите пятизначное число: ");
// var number = Convert.ToInt32(Console.ReadLine());

// if (number >= 10000 && number <= 99999)
// {
//      int division1 = number / 10000;
//         int remainder1 = number % 10;
//             if(division1 == remainder1)
//             {
//                 Console.WriteLine($"Число: {number} палиндром");
//             }
//             else 
//             Console.WriteLine($"Число: {number} НЕпалиндром");
// }
// else
// {
//     Console.WriteLine("Введено некоректное значение, введите ПЯТИзначное число!");

// }




// Доп. задание №1: Представим банк, в котором алгоритм начисления процента по вкладу
// зависит от суммы вклада. На вход будет подаваться число (сумма вклада). 
// При значении меньше 100, будет начислено 5 %, если значение находится 
// в диапазоне от ста до двухсот — 7 %, если больше — 10 %. 
// Отработав, программа должна вывести общую сумму с начисленными процентами.

// Console.Write("Введите сумму вклада: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите срок вклада в месяцах: ");
// int mounthNumber = Convert.ToInt32(Console.ReadLine());
// int secondNumber = 0;
// if (firstNumber <= 99)
// {
//     secondNumber = ((firstNumber*5)/100 + firstNumber)*mounthNumber;
//     Console.WriteLine($"Начислено 5% и общая сумма вклада составит {secondNumber}");
// } 
// else if (firstNumber >=100 && firstNumber <=200)
// {
//     secondNumber = ((firstNumber*7)/100 + firstNumber)*mounthNumber;
//     Console.WriteLine($"Начислено 7% и общая сумма вклада составит {secondNumber}");
// }
// else if (firstNumber > 200)
// {
//     secondNumber = ((firstNumber*10)/100 + firstNumber)*mounthNumber;
//     Console.WriteLine($"Начислено 10% и общая сумма вклада составит {secondNumber}");
// }

// Доп. задание №2:
// Назовем число интересным, если в нем разность максимальной и минимальной цифры 
// равняется средней по РАСПОЛОЖЕНИЮ цифре. Напишите программу, 
// которая определяет интересное число или нет. Если число интересное, 
// следует вывести – «Число интересное» иначе «Число неинтересное».
// -> 954 - число интересное, средняя цифра - 5, разница: 9 - 4 = 5.
// Средняя цифра - цифра(962-6, 23456 - средняя 4)

// Console.Write("Введите трехзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// var number1 = number / 100;
// var number2 = (number / 10) % 10;
// var number3 = number % 10;

// var maxNumber = number1;
// var minNumber = number1;

// if (number2>maxNumber) maxNumber = number2;
// if (number3>maxNumber) maxNumber = number3;

// if (number2<minNumber) minNumber = number2;
// if (number3<minNumber) minNumber = number3;

// var number4 = number1 + number2+ number3 - maxNumber - minNumber;
// if ((maxNumber - minNumber) == number4)
// {
//         Console.WriteLine($"Число {number} интересное");

// }
// else
// {
//     Console.WriteLine($"Число {number} НЕинтересное");
// }