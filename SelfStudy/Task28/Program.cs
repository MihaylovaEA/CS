// 28. Подсчитать сумму цифр в числе

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int sumDigits = SumDigits(number);
Console.WriteLine(sumDigits);

int SumDigits (int num) 
{
    if (num < 0) num = -num;
    int count = 0;
    int sum = 0;
    int rem = 0;
    while (num > 0)
    {
        rem = num % 10;
        num = num / 10;
        sum = sum + rem;
        count++;
    }
    return sum;
}