// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

// int FactorialRec(int n)
//  {
//      if (n == 1) return 1;
//      else return n * FactorialRec(n - 1);
//  }

//  Console.WriteLine(FactorialRec(10)); // 3628800




int DegreeNumbers(int num, int num1)
{
    if (num1 == 0) return 1;
    else return num * DegreeNumbers(num, num1 - 1);
}

Console.WriteLine("Введите натуральное число M");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N");
int number1 = Convert.ToInt32(Console.ReadLine());
int degreeNumbers = DegreeNumbers(number, number1);
Console.WriteLine(degreeNumbers);