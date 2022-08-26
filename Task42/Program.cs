// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

System.Console.WriteLine("Введите 1е число");
int a = Convert.ToInt32(Console.ReadLine());

int ChangeToBin(int a1)
{
    int i1 = 0;
    int m =1;
    while (a1 > 0)
    {
        i1 +=  a1 % 2*m;
        a1 = a1 / 2;
        m *= 10;
    }
    return i1;
    

};

int bin = ChangeToBin(a);
System.Console.WriteLine(bin);