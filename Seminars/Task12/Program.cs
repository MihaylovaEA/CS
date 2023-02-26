// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите первое число ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int modDiv = ModDiv(firstNumber, secondNumber);
/*if (modDiv == 0)
    Console.WriteLine($"Число {firstNumber} кратно числу {secondNumber}");
else 
{
    Console.WriteLine($"Число {firstNumber} не кратно числу {secondNumber}");
    Console.WriteLine($"Остаток от деления {modDiv}");
}*/

Console.WriteLine(modDiv == 0 ? "Кратно" : $"Не кратно, остаток -> {modDiv}");


int ModDiv (int num1, int num2)
{
    int div = num1 % num2;
    return div;
}