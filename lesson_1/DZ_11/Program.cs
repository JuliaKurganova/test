Console.WriteLine("Ведите трёхзначное число");
int num1 = int.Parse(Console.ReadLine()!);
if ((num1 >= 100) && (num1 < 1000))
{
    int firestDigit = num1 % 100;
    int secondDigit = firestDigit / 10;
    Console.WriteLine(secondDigit);
}
else
{
    Console.WriteLine("Введено не трёхзначное число");
}