// Задача 29: Напишите программу, которая задаёт 
// эмассив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]


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
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length) Console.Write($" {arr[i]} ,");

    }
    Console.Write(arr[arr.Length - 1]);
    Console.Write("]");
}
int[] arr = CreateNewArr(8, -100, 100);
PrintArr(arr);




