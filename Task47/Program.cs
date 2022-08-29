// Задача 47: Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.





double[,] CreateNewMatrixRnd(int row, int col, int min, int max)
{
    double[,] matrix = new double[row, col];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)

            matrix[i, j] = rnd.Next(min, max) -rnd.NextDouble()*10-min;
    }
    return matrix;
}

void PrintArr(double[,] matrix)
{
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write(" [");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1)-1) Console.Write($" { Math.Round(matrix[i, j],1) ,4} ,");
            else Console.Write($"  { Math.Round(matrix[i, j],1) ,4 }") ;
        }
    
    
    Console.WriteLine(" ]");
    }
}

double[,] matrix = CreateNewMatrixRnd(4, 4, -10, 10);
PrintArr(matrix);