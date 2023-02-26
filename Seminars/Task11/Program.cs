//11. Напишите программу, которая 
//1. выводит случайное трёхзначное число и 
//2. удаляет вторую цифру этого  числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine ($"Случайное трехзначное число: {number}");

// int firstDigit = number / 100;
// int thirdDigit = number % 10;
// int result = firstDigit * 10 + thirdDigit;

int newNumber = DeleteSecond(number);
Console.WriteLine($"Полученное число: {newNumber}");

int DeleteSecond (int num)
{
    int firstDigit = number / 100;
    int thirdDigit = number % 10;
    int result = firstDigit * 10 + thirdDigit;
    return result;
}