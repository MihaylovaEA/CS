// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
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

int [,] CreateNewArray(int[,] arr)
{
    int[,] matrix = new int[arr.GetLength(1),arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(1); i++)                      //for (int i = 0; i < matrix.GetLength(0); i++)               
    {
        for (int j = 0; j < arr.GetLength(0); j++)                  ////for (int j = 0; j < matrix.GetLength(1); i++)
        {
            matrix[i,j] = arr[j,i];
        }
    }
    return matrix;
}


int[,] matrix = CreateMatrixRndInt(4, 5, 0, 11);
PrintMatrix(matrix);
//if (matrix.GetLength(0) == matrix.GetLength(1))
//{
    int[,] newMatrix = CreateNewArray(matrix);
    System.Console.WriteLine();
    PrintMatrix(newMatrix);
//}
//else
//{
  //  Console.WriteLine("Матрица не является симметричной");
//}