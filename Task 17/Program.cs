
// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).



Console.WriteLine("Номер четветри");
int number = Convert.ToInt32(Console.ReadLine());

string QartNumb(int numb)
{
    if (numb == 1) return "Значения переменных : х > 0 и y > 0 ";
    if (numb == 2) return "Значения переменных : х < 0 и y > 0 ";
    if (numb == 3) return "Значения переменных : х < 0 и y < 0 ";
    if (numb == 4) return "Значения переменных : х > 0 и y < 0 ";
    return "Указана некорректная четверть ";
}
string result = QartNumb(number);
Console.WriteLine(result);