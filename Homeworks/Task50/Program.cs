// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет

int[,] CreateMatrixRndInt(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col]; // 0, 1
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine();
    }
}

bool Check (int row, int col, int[,] matrix)
{
    return row <= matrix.GetLength(0) && col <= matrix.GetLength(1);
}

int ChoiseElement(int row, int col, int[,] matrix)
{
    return matrix[row - 1, col - 1];
}


Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array2d = CreateMatrixRndInt(3, 4, -100, 100);
PrintMatrix(array2d);

Console.WriteLine("Введите номер строки: ");
int userRow = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер столбца: ");
int userColumn = Convert.ToInt32(Console.ReadLine());

int choiseElement = ChoiseElement(userRow, userColumn, array2d);
string result = Check(userRow, userColumn, array2d) ? $"На позиции ({userRow}, {userColumn}) находится элемент {choiseElement}" :
                            "Такого элемента в массиве нет";
Console.WriteLine(result);