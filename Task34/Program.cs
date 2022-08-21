// Задача 34: Задайте массив заполненный случайными 
// положительными трёхзначными числами. Напишите программу,
//  которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите размер массива");
int lengthArr=  Convert.ToInt32(Console.ReadLine());
int[] CreateNewArr(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length-1; i++)
    {
        if (i < arr.Length) Console.Write($" {arr[i]} ,");

    }
    Console.Write(arr[arr.Length - 1]);
    Console.Write("]");
}

int  SortArr(int[] arr)
{
    int count =0 ;
    for (int i = 0; i < arr.Length; i++)
    {
          if (arr[i]%2 ==0 ) count ++;

    }
    return count ;
}
int[] arr = CreateNewArr(lengthArr , 100, 1000);
PrintArr(arr);
int result = SortArr( arr);
Console.WriteLine("\nЧисло четных элементов "+result);