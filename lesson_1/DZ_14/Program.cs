bool DEBUG = false;
Random rnd = new Random();

Console.WriteLine("Hello, user!");

int[] linear = new int[rnd.Next(5, 26)];

int[] a2 =FillArray(linear, 100, 999);
int counts = EvenCount(a2);
Console.WriteLine(counts);


int[] FillArray(int[] field, int fmin, int fmax)
{
    for (int i = 0; i < field.Length; i++)
    {
        field[i] = rnd.Next(fmin, fmax + 1);
        if (DEBUG == true) Console.Write(field[i] + " ");
    }
    if (DEBUG == true) Console.WriteLine(" -->" + field.Length);
    return field;
}

int EvenCount(int[] arr) 
{
    int cntr = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
             cntr++;
            if (DEBUG == true) Console.Write(arr[i] + " "); 
        }
    }
    return cntr;
}
