// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. (Задачи, решенные через Math.Pow, не будут считаться правильными, так как задача стоит в том, чтобы написать цикл)

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int numberA = ReadInt("Введите число A: ");
int numberB = ReadInt("Введите число B: ");
NaturalDegree(numberA, numberB);


// Функция возведения в степень
void NaturalDegree(int a, int b)
{
  int result = 1;
  for (int i = 1; i <= b; i++)
  {
    result = result * a;
  }
  Console.WriteLine($"Число {a} в степени {b} -> {result}");
}

// Функция ввода
int ReadInt(string message)
{
  Console.WriteLine(message);
  return Convert.ToInt32(Console.ReadLine());
}
