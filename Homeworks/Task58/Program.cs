// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

bool Check(int[,] matrixA, int[,] matrixB)
{
    return matrixA.GetLength(1) == matrixB.GetLength(0);
}

int[,] Product(int[,] matrixA, int[,] matrixB)
{
    int[,] product = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

    for (int i = 0; i < product.GetLength(0); i++)
    {
        for (int j = 0; j < product.GetLength(1); j++)
        {
            for (int s = 0; s < matrixA.GetLength(1); s++)
            {
                product[i, j] += matrixA[i, s] * matrixB[s, j];
            }

        }
    }
    return product;
}


Console.WriteLine("Введите количество строк матрицы А: ");
int rowsA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов матрицы А: ");
int columnsA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество строк матрицы В: ");
int rowsB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов матрицы В: ");
int columnsB = Convert.ToInt32(Console.ReadLine());

int[,] matrA = CreateMatrixRndInt(rowsA, columnsA, 0, 10);
Console.WriteLine("матрица A: ");
PrintMatrix(matrA);
Console.WriteLine();

int[,] matrB = CreateMatrixRndInt(rowsB, columnsB, 0, 10);
Console.WriteLine("матрица B: ");
PrintMatrix(matrB);
Console.WriteLine();

bool check = Check(matrA, matrB);
if (check == true)
{
    int[,] productMatrix = Product(matrA, matrB);
    PrintMatrix(productMatrix);
}
else Console.WriteLine("Матрицы перемножить нельзя. Для перемножения матриц количество столбцов матрицы А должно равняться количеству строк марицы В.");

