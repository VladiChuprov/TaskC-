// Задача 15: Напишите программу, которая принимает на вход цифру,
//  обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


Console.WriteLine("Укажите день недели");
int day = Convert.ToInt32(Console.ReadLine());
bool Weekend(int day1)
{
    return day1 == 6 || day1 == 7  ;
}
bool result = Weekend(day);
Console.WriteLine(result ? "Да , это выходной" : "Нет , это не выходной");