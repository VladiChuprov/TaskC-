// Задача 27: Напишите программу, которая принимает
//  на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.Write("Введите число А : ");
int a = Convert.ToInt32(Console.ReadLine());
int Digit(int numb)
{
    int sum = 0;
    while ( numb > 0)
    {
        sum = sum + numb % 10;
        numb = numb / 10;
    }
        return sum;
    }
    int result = Digit(a);
    Console.Write($"Сумма цифр в числе {a} " + result);