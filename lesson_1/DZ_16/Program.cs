//  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Сколько чисел вы хотите ввести");
int num = int. Parse(Console.ReadLine()!);
int [] arr = new int[num];

Console.WriteLine($" -> {CountPositiveNumber(UserFillArray(arr))}");

int[] UserFillArray(int[] array)
{
    for(int j = 0; j < num; j++)
    {
        Console.WriteLine("$ введите {j + 1} число");
        arr[j] = int.Parse(Console.ReadLine()!);
    }
    return array;
}

int CountPositiveNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}