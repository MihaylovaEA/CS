// 25. Найти сумму чисел от 1 до А

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int sum = Sum(number);
Console.WriteLine(sum);

int Sum (int num)
{
    int res = 0;
    for (int i = 1; i <= num; i++)
        res = res + i;
    return res;
}