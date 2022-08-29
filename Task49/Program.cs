// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.

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
int[,] DoubleElements(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)

           if (i%2 ==0 && j%2 ==0)
           matrix[i,j]*= matrix[i,j];
    }
    return matrix;
}

int[,] matrix = CreateNewMatrixRnd(4,4 , -50, 49);
PrintArr(matrix);
int[,] matrixDouble = DoubleElements(matrix);
System.Console.WriteLine("Измененная матрица ");
PrintArr(matrixDouble);
