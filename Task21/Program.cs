// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек
//  и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки А");
Console.Write("Х:");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y:");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z:");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B");
Console.Write("Х:");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y:");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z:");
int z2 = Convert.ToInt32(Console.ReadLine());
double Length(int xA ,int yA , int zA,int xB ,int yB , int zB)
{
return  Math.Sqrt(Math.Pow((xA-xB),2) + Math.Pow((yA-yB),2) + Math.Pow((zA-zB),2));
}
double result = Length (x1,y1,z1,x2,y2,z2);
Console.WriteLine($"Длина отрезка между А ({x1},{y1},{z1}) и В ({x2},{y2},{z2} ) "+Math.Round(result ,3));