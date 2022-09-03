// Задача 56: Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой элементов.



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

void MinColSum(int[,] matrix)
{
    int temp = 0;
    int minSum = 1000000; // Не смог найти метод суммы элементов матрицы
    for (int i = 0; i < matrix.GetLength(0); i++)
    {        
        int minSum1 = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            minSum1 += matrix[i, j];
        }
        if (minSum1 < minSum)
        {
            minSum = minSum1;
            temp = i;
        }
        System.Console.Write($" {minSum} ");
    }
    System.Console.WriteLine($"\nИндекс строки с минимальной суммой элементов {temp}");
}

int[,] matrix = CreateNewMatrixRnd(9, 5, 0, 100);
PrintMatrix(matrix);
System.Console.WriteLine("Cумма каждой  строки");
MinColSum(matrix);