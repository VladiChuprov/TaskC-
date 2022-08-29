﻿// Задача 52: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого
// столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateNewMatrixRnd(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)

            matrix[i, j] = rnd.Next(min, max + 1);
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write(" [");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($" {matrix[i, j],3} ,");
            else Console.Write($" {matrix[i, j],3}");
        }


        Console.WriteLine(" ]");
    }
}
double[] MidleMult(int[,] matrix)
{
    double[] midlSum = new double[matrix.GetLength(1)];
    
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum = sum + matrix[i, j];
        }
        midlSum[j] = sum / (matrix.GetLength(1));
    }
    return midlSum;
}
void PrintArr(double[] arr)
{
    System.Console.WriteLine("Среднее арифметическое столбца");
    Console.Write(" [");
    for (int i = 0; i < arr.Length; i++)
    {

        if (i < arr.Length - 1) Console.Write($" {Math.Round(arr[i],1) ,3} ,");
        else Console.Write($" {Math.Round(arr[i],1) ,3}");
    }
    Console.WriteLine("]");

}


int[,] matrix = CreateNewMatrixRnd(3, 3, 0, 100);
PrintMatrix(matrix);
double[] arr = MidleMult(matrix);
 PrintArr(arr);
