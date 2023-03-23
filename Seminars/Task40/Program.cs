// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

bool IsExistTriangle(int a, int b, int c)
{
return a + b > c && b + c > a && c + a > b;
}

Console.Write("Введите длину стороны А: ");
int sideA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину стороны B: ");
int sideB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину стороны C: ");
int sideC = Convert.ToInt32(Console.ReadLine());
string output = IsExistTriangle(sideA, sideB, sideC) ? "Треугольник может существовать с такими сторонами" : "Треугольник не может существовать с такими сторонами";
Console.WriteLine(output);