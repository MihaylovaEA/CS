// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
//  Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите первое число:");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int secondNumber = Convert.ToInt32(Console.ReadLine());
int sumNumbers = SumNumbers(firstNumber, secondNumber);
if(sumNumbers == 0) Console.WriteLine ("Натуральных чисел в заданном промежутке нет");
else Console.Write($"Сумма чисел равна {sumNumbers}");

int SumNumbers(int num1, int num2)
{
    if (num1 < 0) num1 = 0;
    if (num2 < 0) num2 = 0;
    if (num1 > num2) return num1 + SumNumbers(num1 - 1, num2);
    if (num1 == num2) return num1;
    else return num2 + SumNumbers(num1, num2 - 1);
}