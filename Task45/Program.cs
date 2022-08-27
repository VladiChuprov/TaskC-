// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//   значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)



Console.Write("Введите коэффициент К для 1-ой прямой ");
double kFirst = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите коэффициент b для 1-ой прямой ");
double bFirst = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите коэффициент К для 2-ой прямой ");
double kSecond = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите коэффициент b для 2-ой прямой ");
double bSecond = Convert.ToInt32(Console.ReadLine());

double[] InterLines(double k1, double b1, double k2, double b2)
{
    double[] myArr = new double[2];
    myArr[0] = (b1 - b2 )/ (k2 - k1);
    myArr[1] = myArr[0] * k1 + b1;
    return myArr;

}
void PrintArr(double[] arr)
{
    Console.Write($"Точка пересечения прямых ( {Math.Round(arr[0],2)} ;  {Math.Round(arr[1],2)} ) ");
}

double[] arr = InterLines(kFirst, bFirst, kSecond, bSecond);
PrintArr(arr);

