// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. (Задачи, решенные через Math.Pow, не будут считаться правильными, так как задача стоит в том, чтобы написать цикл)

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// int numberA = ReadInt("Введите число A: ");
// int numberB = ReadInt("Введите число B: ");
// NaturalDegree(numberA, numberB);


// // Функция возведения в степень
// void NaturalDegree(int a, int b)
// {
//   int result = 1;
//   for (int i = 1; i <= b; i++)
//   {
//     result = result * a;
//   }
//   Console.WriteLine($"Число {a} в степени {b} -> {result}");
// }

// // Функция ввода
// int ReadInt(string message)
// {
//   Console.WriteLine(message);
//   return Convert.ToInt32(Console.ReadLine());
// }


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


// int number = ReadInt("Введите число: ");
// int len = NumberLen(number);
// SumNumbers(number, len);


// // Функция ввода
// int ReadInt(string message)
// {
//   Console.Write(message);
//   return Convert.ToInt32(Console.ReadLine());
// }

// // Функция подсчета цифр в числе
// int NumberLen(int a)
// {
//   int index = 0;
//   while (a > 0)
//   {
//     a /= 10;
//     index++;
//   }
//   return index;
// }

// // Функция вывода суммы цифр в числе
// void SumNumbers(int n, int len)
// {
//   int sum = 0;
//   for (int i = 1; i <= len; i++)
//   {
//     sum += n % 10;
//     n /= 10;
//   }
//   Console.WriteLine($"Сумма чисел в цифре -> {sum}");
// }



// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (числа берете любые)

int lenArray = ReadInt("Введите длинну массива: ");

int[] randomArray = new int[lenArray];
System.Console.Write("[ ");
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(10,100);
    Console.Write($"{randomArray[i]} ");
}
System.Console.Write("]");



// Функция ввода
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}