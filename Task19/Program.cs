// Задача 19

// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
bool Palindrome(int num)
{
    int i = 0;
    while (num > i)
    {
        i = i * 10;
        i += (num % 10);
        num = num / 10;
    }
    return num == i || num == i / 10;
}
bool result = Palindrome(number);
Console.WriteLine(result ? "Это число палиндром" : "Это число не палиндром");