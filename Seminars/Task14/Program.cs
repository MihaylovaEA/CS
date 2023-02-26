// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да


Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

bool modDiv = ModDiv(number);
Console.WriteLine(modDiv == true ? "Кратно" : $"Не кратно");


bool ModDiv (int num)
{
    return num % 7 == 0 && num % 23 ==0; 
}