// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.


System.Console.Write("Введите размер массива   ");
int lengthArray = Convert.ToInt32(Console.ReadLine());

int[] CreateNewArr(int size)
{

    int[] myArr = new int[size];
    for (int i = 0; i < myArr.Length; i++)
    {
        System.Console.Write($"Введите {i+1} элемент массива ");
        myArr[i] = Convert.ToInt32(Console.ReadLine());

    }
    return myArr;
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

int PositiveNumb(int[] arr)
{
    int i1=0;
for (int i = 0; i < arr.Length; i++)
{
    
    if (arr[i]>0 )  i1++;
}
return i1;
}
int[] arr = CreateNewArr(lengthArray);
PrintArr(arr);
int res= PositiveNumb(arr);
System.Console.WriteLine($"\nЧисло положительных элементов в массиве  "+res);