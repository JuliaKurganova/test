﻿//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
//  Например, задан массив:
//  1 4 7 2
//  5 9 2 3
//  8 4 2 4
//  1
//  7 -> такого числа в массиве нет


Console.Write(" Введите число ");
int pos1 = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write(" Введите число ");
int pos2 = Convert.ToInt32(Console.ReadLine()) - 1;
int n = 3; // размер массива
int m = 4; // размер массива
Random random = new Random();
int[,] arr = new int[n, m];


for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = random.Next(0, 10);
        Console.WriteLine("{0} ", arr[i, j]);
    }
        Console.WriteLine();
}

if (pos1 < 0 | pos1 > arr.GetLength(0) - 1 | pos2 < 0 | pos2 > arr.GetLength(1) - 1)
{
     Console.WriteLine("Такого числа в массиве нет ");
}
else
{
    Console.WriteLine("{0} ", arr[pos1, pos2]);
}
 
 
        