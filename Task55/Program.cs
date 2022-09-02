// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.


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


int[,] ReversRowCol(int[,] matrix)
{
    int [,] newMatrix = new int [matrix.GetLength(0),matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
    
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            newMatrix[j,i]=  matrix[i, j] ;
            
    }
    }
    return newMatrix ;
}
int[,] matrix = CreateNewMatrixRnd(4,5,0,100);
PrintMatrix(matrix);
int [,]matrix1 =ReversRowCol(matrix);
System.Console.WriteLine("Матрица с измененными строками и столбцами");
PrintMatrix(matrix1);

