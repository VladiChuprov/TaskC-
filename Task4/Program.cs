//  Напишите программу, которая принимает на
// вход три числа и выдаёт максимальное из этих чисел.


Console.WriteLine("Введите число a ");
int numb1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b ");
int numb2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число c ");
int numb3 = Convert.ToInt32(Console.ReadLine());
int max = numb1;
if (numb2 > max)
{
    max = numb2;
}
if (numb3 > max)
{
    max = numb3;
      }
Console.WriteLine($"Максимальное число {max} ");
