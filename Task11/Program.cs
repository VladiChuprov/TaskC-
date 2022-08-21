// // // See https://aka.ms/new-console-template for more information
// // Console.WriteLine("Hello, World!");

// // int number = new Random().Next(10, 100); // 10, 99 + 1
// // Console.WriteLine($"Случайное число из отрезка 10 - 99 => {number}");



// // 14. Напишите программу, которая принимает на
// // вход число и проверяет, кратно ли оно
// // одновременно 7 и 23

// // 14 -> нет
// // 46 -> нет
// // 161 -> да


Console.Write("Please enter the 1st number: ");
int firstNum = Convert.ToInt32(Console.ReadLine());

int Del(int num)
{
    return (num / 10) % 10;
}
int  result = Del(firstNum);
Console.WriteLine(result ? $"Вторая цифра  это {result}" : "Указано некорректное число");


// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет


// Console.Write("Please enter the 1st number: ");
// int firstNum = Convert.ToInt32(Console.ReadLine());

// Console.Write("Please enter the 2st number: ");
// int secondNum = Convert.ToInt32(Console.ReadLine());

// bool Del(int num1, int num2)
// {
//     return num1 * num1 == num2 || num2 * num2 == num1;
// }
// bool result = Del(firstNum, secondNum);
// Console.Write(result ? "Число является квадратом другого" : "Числа не являются квадратами");

