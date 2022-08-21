// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число А : ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B : ");
int b = Convert.ToInt32(Console.ReadLine());
int Sum(int num1, int num2)
{
    int prod = 1;
    for (int count = 1; count <= num2; count++) prod *= num1;
    return prod;
}
int result = Sum(a, b);
Console.WriteLine($"{a} в степени {b}  " + result);