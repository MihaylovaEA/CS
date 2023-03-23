// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int ConvertToTwo(int number)
{
int twoNumber = 0, numDigit = 1;
// for (int i = 0; number != 0; i++)
// {
// twoNumber = twoNumber + (number % 2) * Convert.ToInt32(Math.Pow(10, i));
// number /= 2;
// }
while (number != 0)
{
twoNumber = twoNumber + (number % 2) * numDigit;
number /= 2;
numDigit *= 10;
}
return twoNumber;
}

string ConvertToTwoString(int number)
{
string twoNumber = string.Empty;
while (number != 0)
{
twoNumber = number % 2 + twoNumber;
number /= 2;
}
return twoNumber;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Число {num} в двоичной системе равно: {ConvertToTwo(num)}");