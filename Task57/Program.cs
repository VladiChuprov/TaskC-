// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.


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
int[] SortMatrix(int[,] matrix)
{
    int[] arr = new int[matrix.Length];
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            arr[count] = matrix[i, j];
            count++;
        }
    }
    Array.Sort(arr);
    return arr;

}

void PrintArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        if (i < arr.Length) Console.Write($" {arr[i]} ,");

    }
    Console.Write(arr[arr.Length - 1]);
    Console.WriteLine(" ]");
}

void ElemnsHi(int[] arr)
{
    int num = arr[0];
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {        
        if (arr[i] == num)
        {
            count++;
        }
        else
        {
            Console.WriteLine($" {num} -> {count } ");
            count = 1;
            num = arr[i];
        }
            }
     Console.WriteLine($" {num} -> {count } ");
}

int[,] matrix = CreateNewMatrixRnd(3, 3, 0, 9);
PrintMatrix(matrix);
int[] array = SortMatrix(matrix);
System.Console.WriteLine("Одномерный массив");
PrintArr(array);
ElemnsHi(array);