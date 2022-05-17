using System;

double[,] Generate2Arr(int min = -50, int max = 50, 
    int m = 3, int n = 3)
{
    Random rnd = new Random();
    double[,] result = new double[m, n];

    for(int i = 0; i < m; i++)
    {
        for (var j = 0; j < n; j++)
        {
            result[i, j] = rnd.NextDouble() * (max - min) + min;
        }
    }
    return result;
}

Random rnd = new Random();

//Задайте двумерный массив размером mxn, заполненный случайными вещественными числами

Console.Write("Количество строк (m): ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Количество столбцов (n): ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] myArr = Generate2Arr(m:m, n:n);

for(int i = 0; i < m; i++)
{
    for (var j = 0; j < n; j++)
    {
        Console.Write(Math.Round(myArr[i, j], 2) + " ");
    }
        Console.WriteLine();
}

//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента
//этого элемента или же указание, что такого элемента нет

Console.Write("Номер строки (m): ");
m = Convert.ToInt32(Console.ReadLine());

Console.Write("Номер столбца (n): ");
n = Convert.ToInt32(Console.ReadLine());

if(m > myArr.GetLength(0) + 1 || n > myArr.GetLength(1) + 1)
{
    Console.WriteLine("Выход за пределы границ массива!");
}
else
{
    Console.WriteLine("Ваше число: " + Math.Round(myArr[m - 1, n - 1], 2));
}

//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое в каждом столбце

int[,] randomArr = new int[rnd.Next(10), rnd.Next(10)];

for (var i = 0; i < randomArr.GetLength(0) + 1; i++)
{
    for (var j = 0; j < randomArr.GetLength(1) + 1; j++)
    {
        randomArr[i, j] = rnd.Next(20);
        Console.Write(randomArr[i, j] + " ");
    }
    Console.WriteLine();
}

double[] resultsArr = new double[randomArr.GetLength(1) + 1];

for (var j = 0; j < randomArr.GetLength(1) + 1; j++)
{
    resultsArr[j] = 0;
    for (var i = 0; i < randomArr.GetLength(0) + 1; i++)
    {
        resultsArr[j] += randomArr[i, j];
    }
    resultsArr[j] /= randomArr.GetLength(0) + 1;
}

for (var i = 0; i < resultsArr.Length; i++)
{
    Console.Write(Math.Round(resultsArr[i], 2) + " ");
}