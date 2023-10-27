// // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Console.Write("Введите число А: ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число В: ");
// int B = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{A}, {B} -> {GetPow(A,B)}");
// int GetPow(int A, int B)
// {

// int result = 1;
//   for(int i = 0;i < B;i++)
//   {
//     result *= A;
//   }
//   return result;
// }

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{number} -> {SumOfDigits(number)}");
// int SumOfDigits(int number)
// {
//     int sum = 0;
//   while (number > 0)
//    {
//    sum += number % 10;
//    number/= 10;
//   }
//   return sum;

// }

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int[]result = GetArray(3); 
// Console.WriteLine($"[{String.Join(", ", result)}]");
// int[] GetArray(int size)
// {
//     int[] array = new int [size];
//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(1, 90);
//     }
//     return array;
// }