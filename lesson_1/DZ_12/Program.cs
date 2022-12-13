Random rnd = new Random();
Console.WriteLine("Hello, user!");

int[] linear = new int[rnd.Next(5, 26)];// int[] linear = new int[number];

int[] a2 =FillArray(linear,rnd.Next(5, 26),rnd.Next(26, 50));
int counts = OddSum(a2);
PrintArray(a2);
Console.WriteLine(" Yes" + counts);
//int ccntrr= EvenCount(linear);

int[] FillArray(int[] field, int fmin, int fmax)
{
    for (int i = 0; i < field.Length; i++)
    {
        field[i] = rnd.Next(fmin, fmax + 1);
    }
    return field;
}

int OddSum(int[] arr) 
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i += 2)
    {
        sum += arr[i];
    }
    return sum;
}

void PrintArray(int[] array)
{
   for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
