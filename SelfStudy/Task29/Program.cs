// 29. Написать программу вычисления произведения чисел от 1 до N

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int factorial = Factorial(number);
Console.WriteLine(factorial);

int Factorial (int num)
{
    int res = 1;
    for (int i = 1; i <= num; i++)
        res = res * i;
    return res;
}