// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int sumDigits = SumDigits(number);
Console.WriteLine(sumDigits);

int SumDigits (int num) 
{
    if (num < 0) num = -num;
    int sum = 0;
    int rem = 0;
    for (int i = 0; num > 0; i++)
    {
        rem = num % 10;
        num = num / 10;
        sum = sum + rem;
    }
    return sum;
}