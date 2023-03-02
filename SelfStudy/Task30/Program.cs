// 30. Показать кубы чисел, заканчивающихся на четную цифру

//Уточнение: будем рассматривать числа от 1 до N

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

double[] array = new double [number]; //Создаем массив

//функция заполнения массива кубами числа
void FillArrayCube (double[] arr)
{
    int length = arr.Length;
    int index = 0;
    while (index < length)
    {
        arr[index] = Math.Pow(index + 1, 3);
        index++;
    }
}

//Функция вывода в консоль элементов массива, заканчивающихся на четную цифру
void PrintArrayEven (double[] arr)
{
    int length = arr.Length;
    int index = 0;
    double newNumber = 0;
    while (index < length)
    {
        newNumber = arr[index] % 10;
        if (newNumber % 2 == 0)
            Console.WriteLine(arr[index]);
        index++;
    }
}

//Вызов функций
FillArrayCube(array);
PrintArrayEven(array);