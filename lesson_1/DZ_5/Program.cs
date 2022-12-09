Console.WriteLine("Введите пятизначное число:");
string array = Console.ReadLine()!;

int i = 0;

if  (array[0] == '-' ) i = 1;

if (array[i] == array[4+ i ] && array[1 +i]== array[3 +i])
{
    Console.WriteLine("Число является полиндроном");
}
else
{
    Console.WriteLine("Число неявляется полиндроном");
}
