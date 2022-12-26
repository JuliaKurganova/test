// Задача 66: Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int m = InputInt("Введите M:");
int n = InputInt("Введите N:");
Console.WriteLine($" {CountNaturalSum(m, n)}");//M = {m}; N = {n} ->

int InputInt (string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int CountNaturalSum(int m, int n)
{
    if (m == n)
    {
        return n;
    }
    else
    {
    return n + CountNaturalSum(m, n - 1);
    }
}



/*Console.WriteLine("Введите M:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите N:");
int n = int.Parse(Console.ReadLine());

Console.Write(FromMtoN( 4, 8));
string FromMtoN( int m, int n ) 
{
    string rezult = string.Empty;
    if (m == n)
    {
        return rezult + m.ToString();
    }
    else
    {
        return rezult + n.ToString() + FromMtoN(m, n - 1);
    }
     
}*/