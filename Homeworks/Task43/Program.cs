// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

bool Check(int b1, int k1, int b2, int k2)
{
    if (k1 == k2)
    {
        if (k1 == k2)
        {
            if (b1 == b2) Console.WriteLine("Прямые совпадают");
            else Console.WriteLine("Прямые параллельны");
        }
        
        return false;
    }
    else return true;
}

double CoordX(double b1, double k1, double b2, double k2)
{
    return Math.Round((b1 - b2) / (k2 - k1), 1);
}

double CoordY(double b1, double k1, double b2, double k2)
{
    return Math.Round((k1 * (b1 - b2) + b1 * (k2 - k1)) / (k2 - k1));
}

Console.Write("b1 = ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("k1 = ");
int k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("b2 = ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("k2 = ");
int k2 = Convert.ToInt32(Console.ReadLine());

double x = CoordX(b1, k1, b2, k2);
double y = CoordY(b1, k1, b2, k2);

string point = Check(b1, k1, b2, k2) ? $"({x};{y})" : "";
Console.WriteLine(point);

