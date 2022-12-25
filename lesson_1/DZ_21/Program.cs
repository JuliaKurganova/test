// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
int[,] matrix = CreateMatrix(4, 4, -5, 10);
 
PrintMatrix(matrix);
PrintArray(Average(matrix));
 
void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
 
 void PrintMatrix(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
 
int[,] CreateMatrix(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];
 
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(min, max + 1);
        }
    }
 
    return matrix;
}
 
double[] Average(int[,] matrix)
{
    int columnCount = matrix.GetLength(1);
    int rowCount = matrix.GetLength(0);
    double[] result = new double[columnCount];
 
 
    for (int j = 0; j < columnCount; j++)
    {
        int sum = 0; 
        for (int i = 0; i < rowCount; i++)
        {
            sum += matrix[i,j];
        }
 
        result[j] = Math.Round((double)sum / rowCount, 2);
    }
 
    return result;
}