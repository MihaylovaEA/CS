// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"


Console.WriteLine("Введите натуральное число M");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N");
int number1 = Convert.ToInt32(Console.ReadLine());

NaturalNumbers(number, number1);

void NaturalNumbers(int num, int num1)
{
    if (num < num1)
    {
        NaturalNumbers(num, num1 - 1);
        Console.Write($"{num1} ");
    }

    else if (num > num1)
    {
        Console.Write($"{num} ");
        NaturalNumbers(num - 1, num1);
    }

    else
    {
        Console.Write($"{num} ");

    }
}