// Задача 68: Напишите программу вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n. 

Console.Write("Введите число m ");
int number1= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n ");
int number2 = Convert.ToInt32(Console.ReadLine());

int AkkFunction(int num1 , int num2)
{
    if (num1 ==0)return num2+1;
    if (num1 >0 && num2==0)return AkkFunction(num1-1,1);
    if (num1 >0 && num2>0)return AkkFunction (num1-1 ,AkkFunction(num1,num2-1));
return AkkFunction(num1, num2);
}

System.Console.WriteLine($"Функция Аккермана для чисел A({number1},{number2}) = {AkkFunction(number1, number2)}" );