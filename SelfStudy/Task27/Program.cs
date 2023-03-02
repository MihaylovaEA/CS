// 27. Определить количество цифр в числе

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int digits = Digits(number);
Console.WriteLine(digits);

int Digits (int num) 
{
    if (num < 0) num = -num;
    int count = 0;
    while (num > 0)
    {
        num =num / 10;
        count++;
    };
    return count;
};