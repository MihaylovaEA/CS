// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int posNumber = Negative(number); //Делаем все числа положительными для приведения к общему случаю
int reverse = Reverse(posNumber); //"Переворачиваем" число
bool checkPall = CheckPall(posNumber, reverse); //Проверяем является ли паллиндромом
string result = checkPall ? "Да" : "Нет"; //Сохраняем результат
Console.WriteLine(result); //Вывод результата

//Функция поиска "перевернутого" числа
int Reverse (int num) 
{
    int newNum = 0;
    for (int i = 0; num > 0; i++)
    {
        newNum = newNum * 10 + num % 10;
        num =num / 10;
    };
    return newNum;
};

//Функция проверки числа на паллиндром
bool CheckPall (int num, int rev)
{
    return num == rev;
};

//Функция обработки отрицательных чисел
int Negative (int num)
{
    if (num  > 0) return num;
    else return -num;
};