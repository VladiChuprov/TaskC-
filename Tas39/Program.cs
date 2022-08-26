// Задача 39: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]


Console.WriteLine("Введите размер массива");
int lengthArr = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение минимального  элемента");
int minArr = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение максимальнго элемента");
int maxArr = Convert.ToInt32(Console.ReadLine());
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
    for (int i = 0; i < arr.Length - 1; i++)
    {
        if (i < arr.Length) Console.Write($" {arr[i]} ,");

    }
    Console.Write(arr[arr.Length - 1]);
    Console.Write(" ]\n");
}

void SumOddInd(int[] arr)
{
    for (int i = 0; i < arr.Length / 2; i++)
    {
        int temp = arr[i];
        arr[i] = arr[arr.Length - 1-i];
        arr[arr.Length - 1-i] = temp;

    }
    return ;
}

int[] arr = CreateNewArr(lengthArr, minArr, maxArr);
PrintArr(arr);
SumOddInd(arr);
PrintArr(arr);
