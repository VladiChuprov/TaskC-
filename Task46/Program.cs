// Задайте двумерный массив n x m 
// заполненный сучайными целыми числами 


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

int[,] matrix = CreateNewMatrixRnd(4, 5, -100, 100);
PrintArr(matrix);