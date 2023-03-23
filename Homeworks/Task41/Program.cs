// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


int[] CreateUserArray (int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int CountNegativeElements (int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0) count++;
    }
    return count;
}

Console.WriteLine("Введите число M: ");
int sizeUserArray = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Введите {sizeUserArray} чисел:");
int[] userArray = CreateUserArray(sizeUserArray);

int result = CountNegativeElements(userArray);
Console.WriteLine($"Вы ввели отрицательных чисел - {result}");