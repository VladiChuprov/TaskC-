// Задача 50: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

Console.Write("Укажите индекс строки массива ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите индекс cтобца массива ");
int col = Convert.ToInt32(Console.ReadLine());


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
            if (j < matrix.GetLength(1) - 1) Console.Write($" {matrix[i, j],3} ,");
            else Console.Write($" {matrix[i, j],3}");
        }
        Console.WriteLine(" ]");
    }
}
void CheckElement(int[,] matrix, int row1, int col1)
{
               if (row1 >= matrix.GetLength(0) || col1 >= matrix.GetLength(1))
            {
                Console.WriteLine("Элемента с такими индексами нет ");
                 
            }
            
    
    Console.WriteLine($"Элемент с индексами ({row1};{col1}) это {matrix[row1-1, col1-1]}");
    
}

int[,] matrix = CreateNewMatrixRnd(4, 4, -50, 49);
PrintArr(matrix);
CheckElement(matrix,row,col);


