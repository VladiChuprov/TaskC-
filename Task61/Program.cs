// Задача 60: Сформируйте трёхмерный массив из неповторяющихся
// двузначных чисел. Напишите программу, которая будет построчно выводить
// массив, добавляя индексы каждого элемента.

int[,,] CreateNew3DMatrixRnd(int row, int col, int weh, int min, int max)
{
  int[,,] matrix = new int[row, col, weh];
  int[] temp = new int[row * col * weh];
  int  number;
  for (int i = 0; i < temp.Length; i++)
  {
    temp[i] = new Random().Next(min, max);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(min, max);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count =0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] =temp[count];  
                count++;              
            }
    }
    return matrix;
}

void Print3DMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write(" [");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (k < matrix.GetLength(2) - 1) Console.Write($" {matrix[i, j, k]} ({i},{j},{k}) ,");
                else Console.Write($" {matrix[i, j, k]} ({i},{j},{k})");
            }
        }
        Console.WriteLine(" ]");
    }
}

int[,,] matrix3D = CreateNew3DMatrixRnd(2, 2, 2, 10, 20);
Print3DMatrix(matrix3D);