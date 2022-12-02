Console.WriteLine(" Введите целое число больше нуля ");
string num1 = Console.ReadLine()!;
int num1int = int.Parse(num1);

for (int i = 1; i <= num1int ; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine( i );
    } 
}