// Задача 15: Напишите программу, которая 
// 1. принимает на вход цифру, обозначающую день недели, и 
// 2. проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру, обозначающую день недели (где 1 - это понедельник, ..., 7 - воскресенье):");
int numberOfDay = Convert.ToInt32(Console.ReadLine());

if (numberOfDay > 0 && numberOfDay < 8)
{
    bool weekend = Weekend(numberOfDay);
    Console.WriteLine(weekend ? "Да" : "Нет");
}
else Console.WriteLine("Цифра выходит за пределы отрезка [1; 7]");

bool Weekend (int num)
{
    return (num == 6 || num == 7);
}