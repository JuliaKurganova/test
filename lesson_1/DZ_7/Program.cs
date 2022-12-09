Console.WriteLine("Введите число, ввод знака '-' не учитывается");
int N = Math.Abs(int.Parse(Console.ReadLine()!));

for (int i = 1 ; i <= N ; i ++)
{
    Console.WriteLine(Math.Pow(i,3));
} 