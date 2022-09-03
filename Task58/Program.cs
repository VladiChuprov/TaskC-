// Задача 58: Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.



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

int[,] MultiMatrix(int[,] matrix , int[,] matrix2)
{
    int[,] matrixMulti = new int[matrix.GetLength(0), matrix2.GetLength(1)];

  for (int i = 0; i < matrixMulti.GetLength(0); i++)
    {
        for (int j = 0; j < matrixMulti.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < matrixMulti.GetLength(1); k++)
            {
                sum += matrix[i, k] * matrix2[k, j];
            }
            matrixMulti[i, j] = sum;
        }
    }
  return matrixMulti;
}

int[,] matrix = CreateNewMatrixRnd(3, 3, 0, 10);
int[,] matrix2 = CreateNewMatrixRnd(3, 3, 0, 10);
System.Console.WriteLine("Первая матрица");
PrintMatrix(matrix);
System.Console.WriteLine("Вторая матрица");
PrintMatrix(matrix2);
int [,] multiMatrix = MultiMatrix(matrix,matrix2);
System.Console.WriteLine("Матрица произведения");
PrintMatrix(multiMatrix);