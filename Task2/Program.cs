// Напишите программу, которая на вход принимает два числа и выдаёт,
//  какое число большее, а какое меньшее.


Console.WriteLine("Введите число a ");
int numb1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b ");
int numb2 = Convert.ToInt32(Console.ReadLine());
  if ( numb1 > numb2 )
{ 
Console.WriteLine($" Число {numb1} > {numb2} ");
}
else
{
    Console.WriteLine($"Число {numb2} > {numb1} ");
}



