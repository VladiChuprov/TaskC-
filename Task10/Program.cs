// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
//  и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите 3х значное число  ");
int numbFirst = Convert.ToInt32(Console.ReadLine());
int Convert(int numb)
{
    result((numb / 10) % 10);
}
int result =Convert(numbFirst);
Console.WriteLine($"Вторая цифра числа {numbFirst} это {result}");