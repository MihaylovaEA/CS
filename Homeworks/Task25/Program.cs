// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Введите число А:");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень B: ");
int degree = Convert.ToInt32(Console.ReadLine());

int exp = Exponentiation(number, degree);
Console.WriteLine($"{number} в степени {degree} = {exp}");

int Exponentiation (int num, int deg)
{
    int res = 1;
   for (int i = 1; i <= deg; i++)
        res = res * num;
    return res;
}