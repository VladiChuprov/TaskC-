// Задача 36: Задайте одномерный массив, заполненный случайными числами.
//  Найдите сумму элементов, стоящих на нечётных позициях (индексах).
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
    Console.Write(" ]");
}

int SumOddInd(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 1) count += arr[i];

    }
    return count;
}
int[] arr = CreateNewArr(lengthArr, minArr, maxArr);
PrintArr(arr);
int result = SumOddInd(arr);
Console.WriteLine("\nСумма элементов на нечетных позициях " + result);