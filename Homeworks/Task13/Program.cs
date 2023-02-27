// Задача 13: Напишите программу, которая 
// 1.выводит третью цифру заданного числа или 
// 2. сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99)
{
    int thirdDigit = ThirdDigit(number);
    Console.WriteLine($"Третья цифра числа -> {thirdDigit}");
}
else Console.WriteLine($"Третьей цифры нет");

int ThirdDigit (int num)
{
    int newNumber = number;
    while (newNumber > 999)
        newNumber = newNumber / 10;
    return newNumber % 10;
}