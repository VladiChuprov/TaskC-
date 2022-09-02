// Задача 59: Задайтедвумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.


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

int[] MinElement(int[,] matrix)
{
    int[] minElem = new int[2];
    int min = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)

            if (matrix[i, j] < min)
            {
                minElem[0] = i;
                minElem[1] = j;
                min = matrix[i, j];
            }
    }
    return minElem;
}
void PrintArr(int[] arr)
{
    Console.Write(" [");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        if (i < arr.Length) Console.Write($" {arr[i]} ,");

    }
    Console.Write(arr[arr.Length - 1]);
    Console.WriteLine(" ]");
}
int[,] DeletColRowMatrix(int[,] matrix, int[] arr)
{
    int[,] matrixDelColRow = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int i1 = 0;
    int j1 = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i != arr[0] && j != arr[1])
            {
                matrixDelColRow[i1, j1] = matrix[i, j];
                j1++;
            }            
        }
        j1=0 ;
        if (i != arr[0]) i1++;
    }
    return matrixDelColRow;
}
void PrintDeletMatrix(int[,] matrix)
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


int[,] matrix = CreateNewMatrixRnd(5, 5, 0, 50);
PrintMatrix(matrix);
int[] array = MinElement(matrix);
System.Console.WriteLine("Индексы минимального элемента");
PrintArr(array);
int[,] deleteMatrix = DeletColRowMatrix(matrix, array);
System.Console.WriteLine("Матрица с удаленными минимальными строкой и столбцом");
PrintDeletMatrix(deleteMatrix);


