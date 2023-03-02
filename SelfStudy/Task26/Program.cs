// 26. Возведите число А в натуральную степень B используя цикл

Console.WriteLine("Введите число А:");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень B: ");
int degree = Convert.ToInt32(Console.ReadLine());

int exp = Exponentiation(number, degree);
Console.WriteLine($"{number} в степени {degree} = {exp}");

int Exponentiation (int num, int deg)
{
    int res = 1;
    int count = 1;
    while (count <= deg)
    {
        res = res *num;
        count++;  
    }
    
    /*for (int i = 1; i <= deg; i++)
        res = res * num;*/
    return res;
}