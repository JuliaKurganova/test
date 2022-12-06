Console.WriteLine("Введите номер дня недели (1-7)");
int num1 = int.Parse(Console.ReadLine()!);

if (num1 > 0 && num1 < 8)
{
    if (num1 == 6 ||  num1 == 7)
    {
        Console.WriteLine("Выходной");
    }
    else
    {
        Console.WriteLine("Буднии");
    }
}
else
{
    Console.WriteLine("Вы ввели чило выходящее за диапозон от 1 до 7");
}