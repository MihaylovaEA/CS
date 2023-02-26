// 9. Напишите программу, которая
// 1. Выводит случайное число из отрезка [10, 99] и
// 2. Показывает наибольшую цифру числа.

// 78 -> 8
// 12 -> 2
// 85 -> 8

int number = new Random().Next(10,100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 -> {number}");

int firstDigit = number / 10;
int secondDigit = number % 10; //остаток от деления

// if (firstDigit > secondDigit) 
//     Console.WriteLine($"Наибольшая цифра числа -> {firstDigit}");
// else 
//     Console.WriteLine($"Наибольшая цифра числа -> {firstDigit}");

//тернарный оператор:
// int result = firstDigit > secondDigit ? firstDigit : secondDigit;
// Console.WriteLine($"Наибольшая цифра числа -> {result}");

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа -> {maxDigit}");

int MaxDigit (int num) //
{
    int firstDigit = num / 10;
    int secondDigit = num % 10; //остаток от деления
    int result = firstDigit > secondDigit ? firstDigit : secondDigit;
    return result;
}