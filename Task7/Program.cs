﻿// : Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает последнюю цифру этого числа.


Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
int M = (n%10);
Console.WriteLine($"Последняя цифра числа {n} это {M});
