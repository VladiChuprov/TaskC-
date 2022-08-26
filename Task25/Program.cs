// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число А : ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B : ");
int b = Convert.ToInt32(Console.ReadLine());
double Sum(int num1, int num2)
{
    double prod = 1;
    if (num2 >=0 )
    {
        for (int count = 1; count <= num2; count++) prod *= num1;
    }else for (int count1 = -1; count1 <= num2; count1--) prod *= 1/num1;
    return prod;
}
double result = Sum(a, b);
Console.WriteLine($"{a} в степени {b}  " + Math.Round(result,2));