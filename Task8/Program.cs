﻿// Напишите программу, которая на вход принимает число (N), а на выходе 
// показывает все чётные числа от 1 до N.


// Console.WriteLine("Укажите целое число");
// int num = Convert.ToInt32(Console.ReadLine());
// int i = 1;
// for (i <= num; i += 2)
//         Console.WriteLine(i);


Console.WriteLine("Введите целое число  ");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= n; i++)
    if (i % 2 == 0)
        Console.WriteLine(i);

