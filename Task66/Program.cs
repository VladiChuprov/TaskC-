// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

Console.Write("Введите число ");
int number1= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число ");
int number2 = Convert.ToInt32(Console.ReadLine());

void SumNaturalNumber(int num1 , int num2,int sum)
{
    sum = sum + (num1++);    
    if (num1> num2) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    
    SumNaturalNumber(num1, num2,sum);  
    }

SumNaturalNumber(number1 , number2,0);