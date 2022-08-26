// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины

System.Console.WriteLine("Введите 1е число");
int a =Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите 2е число");
int b =Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите 3е число");
int c =Convert.ToInt32(Console.ReadLine());
void CreateTriangle(int a1 , int b1 , int c1)
{
if ( a1+b1 >c1 && a1+c1 >b1 && c1+b1 >a1  )
{
      System.Console.WriteLine("Треугольник с такими сторонами возможен");
}
else System.Console.WriteLine("Треугольник с такими сторонами не возможен");

}

CreateTriangle(a,b,c);