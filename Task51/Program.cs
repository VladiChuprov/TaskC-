// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.

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

void PrintArr(int[,] matrix)
{
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write(" [");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1)-1) Console.Write($" {matrix[i, j] ,3} ,");
            else Console.Write($" {matrix[i, j] ,3}");
        }
    
    
    Console.WriteLine(" ]");
    }
}
int SumDialogi(int[,] matrix)
{
    int sum=0;
for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)

           if (i == j)
           sum = sum +matrix[i,j];
    }
    return sum;
}
int[,] matrix = CreateNewMatrixRnd(4,4 , -50, 49);
PrintArr(matrix);
int sumDialogi = SumDialogi(matrix);
System.Console.WriteLine("Сумма чисел главной диагонали " +sumDialogi);
