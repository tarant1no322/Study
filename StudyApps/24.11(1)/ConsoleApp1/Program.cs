using System;
using System.IO;

int n = 0;
//string s;
double sum = 0.0, t;

Console.WriteLine("Укажите желаемое количество чисел для ввода:");
try
{
    n = Int32.Parse(Console.ReadLine());
}
catch(FormatException ex)
{
    Console.WriteLine("Возникла ошибка " + ex.Message);
    return;
}
catch (OverflowException ex)
{
    Console.WriteLine("Возникла ошибка " + ex.Message);
    return;
}

Console.WriteLine("Введите по очереди " + n + "чисел:");
for(int i = 0; i < n; i++)
{
    try
    {
        t = Double.Parse(Console.ReadLine());
    }
    catch (FormatException ex)
    {
        Console.WriteLine("Возникла ошибка " + ex.Message);
        t = 0.0;
        return;
    }
    catch (OverflowException ex)
    {
        Console.WriteLine("Возникла ошибка " + ex.Message);
        t = 0.0;
        return;
    }
    sum += t;
}
Console.WriteLine($"Среднее арифметическое:{sum / n}");
