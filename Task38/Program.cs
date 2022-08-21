// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.WriteLine("Введите размер массива");
int lengthArr = Convert.ToInt32(Console.ReadLine());

double[] CreateNewArr(int size)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.NextDouble()*100;
    }
    return arr;
}

void PrintArr(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        if (i < arr.Length) Console.Write($" { Math.Round(arr[i], 1)} ,");

    }
    Console.Write($" {Math.Round(arr[arr.Length - 1],1)}");
    Console.Write(" ]");
}

double DifferMaxMin(double[] arr)
{
    double max = arr[0];
    double min = arr[1];
    double diff  = 0;
    if (arr[0]<arr[1])max=min ;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max= arr[i];
        else if (arr[i]<min) min =arr[i];

    }
    diff = max-min;
    return diff;
}
double[] arr = CreateNewArr(lengthArr);
PrintArr(arr);
double result =  DifferMaxMin(arr);
Console.WriteLine("\nРазница между наибольшим и наименьшим элементами " +Math.Round (result,1));