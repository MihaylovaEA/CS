// Задача 10: Напишите программу, которая 
// 1.принимает на вход трёхзначное число и 
// 2.на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
    int secondDigit = SecondDigit(number);
    Console.WriteLine($"Вторая цифра числа -> {secondDigit}");
}
else Console.WriteLine($"Число {number} не является трехзначным!");
int SecondDigit (int num)
{
    return ((number / 10) % 10);
}