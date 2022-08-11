// Задача 13: Напишите программу, которая выводит третью цифру заданного  
// числа или сообщает, что третьей цифры нет. Решить без использования строк.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите  число");
int numb = Convert.ToInt32(Console.ReadLine());
int ThedNumb(int number)
{
    while (number > 999) number = number / 10;
    number = number % 10;
    return number;
}
int result = ThedNumb(numb);
if (numb < 100)
{
    Console.WriteLine("Указано некорректное число");
}
else
{
    Console.WriteLine($"Третья цифра числа {numb} это {result}");
}