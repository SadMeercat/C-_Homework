using System;

int[,] Rnd2Array(int N = 4, int M = 4)
{
    Random rnd = new Random();
    int[,] array = new int[N, M];

    for (var i = 0; i < N; i++)
    {
        for (var j = 0; j < M; j++)
        {
            array[i, j] = rnd.Next(15);
        }
    }
    return array;
}

void PrintArray(int[,] arr)
{
    for (var i = 0; i < arr.GetLength(0); i++)
    {
        for (var j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[] BubbleSort(int[] array)
{
	for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length - 1; j++)
        {
            if (array[j] < array[j + 1])
	        {
		        int t = array[j + 1];
		        array[j + 1] = array[j];
		        array[j] = t;
    	    }
        }
    }
	return array;
}

float factorial(int n)
{
    float i, x = 1;
    for (i = 1; i <= n; i++)
    {
        x *= i;
    }
    return x;
}

//Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Наименьший элемент - 1, на выходе получим
//следующий массив:
//9 4 2
//2 2 6
//3 4 7

Console.Write("Строк M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Столбцов N: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Rnd2Array(m, n);
int[,] resultArray = new int[m - 1, n - 1];

Console.WriteLine("Изначальный массив: ");
PrintArray(myArray);

int row = 0;
int col = 0;
int minVal = myArray[0, 0];

for (var i = 0; i < myArray.GetLength(0); i++)
{
    for (var j = 0; j < myArray.GetLength(1); j++)
    {
        if(myArray[i, j] < minVal)
        {
            minVal = myArray[i, j];
            row = i;
            col = j;
        }
    }
}

Console.WriteLine("Минимальное значение: " + minVal);
Console.WriteLine("Координаты: " + (row + 1) + " " + (col + 1));

int posX = 0;
int posY = 0;

for (var i = 0; i < resultArray.GetLength(0); i++)
{
    if(posX == row)
    {
        posX++;
    }
    for (var j = 0; j < resultArray.GetLength(1); j++)
    {
        if(posY == col)
        {
            posY++;
        }
        resultArray[i,j] = myArray[posX, posY];
        posY++;
    }
    posY = 0;
    posX++;
}

Console.WriteLine("Конечный массив");
PrintArray(resultArray);

//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.Write("Строк M: ");
m = Convert.ToInt32(Console.ReadLine());

Console.Write("Столбцов N: ");
n = Convert.ToInt32(Console.ReadLine());

myArray = Rnd2Array(m, n);

Console.WriteLine("Начальный массив");
PrintArray(myArray);

for (var i = 0; i < myArray.GetLength(0); i++)
{
    int[] tempArray = new int[myArray.GetLength(1)];
    for(int j = 0; j < myArray.GetLength(1); j++)
    {
        tempArray[j] = myArray[i, j];
    }
    tempArray = BubbleSort(tempArray);

    for (var j = 0; j < myArray.GetLength(1); j++)
    {
        myArray[i, j] = tempArray[j];
    }
}

Console.WriteLine("Конечный массив: ");
PrintArray(myArray);

//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

m = 7;
n = 3;

myArray = Rnd2Array(m, n);
Console.WriteLine("Размер 7 на 3");
Console.WriteLine("Начальный массив");
PrintArray(myArray);

int resSumm = 0;

for (var i = 0; i < myArray.GetLength(1); i++)
{
    resSumm += myArray[0, i];
}
int resPos = 0;

for (var i = 0; i < myArray.GetLength(0); i++)
{
    int tempSumm = 0;
    for (var j = 0; j < myArray.GetLength(1); j++)
    {
        tempSumm += myArray[i, j];
    }
    Console.WriteLine($"Сумма {i + 1} сроки: " + tempSumm);
    if(resSumm > tempSumm)
    {
        resSumm = tempSumm;
        resPos = i;
    }
}

Console.WriteLine("Строка с наименьшей суммой: " + (resPos + 1));

//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Random rnd = new Random();

m = rnd.Next(1,9);
n = rnd.Next(1,9);

int[,] firstArr = Rnd2Array(m, n);
Console.WriteLine("Первая матрица:");
PrintArray(firstArr);

m = rnd.Next(1,9);

int[,] secArr = Rnd2Array(n, m);
Console.WriteLine("Вторая матрица:");
PrintArray(secArr);

int[,] result = new int[firstArr.GetLength(0), secArr.GetLength(1)];

for (int i = 0; i < firstArr.GetLength(0); i++)
{
    for (int j = 0; j < secArr.GetLength(1); j++)
    {
        for (int k = 0; k < secArr.GetLength(0); k++)
        {
            result[i,j] += firstArr[i,k] * secArr[k,j];
        }
    }
}

Console.WriteLine("Результат:");
PrintArray(result);

//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] my3Array = new int[3,3,2];
int count = 10;


for (var i = 0; i < my3Array.GetLength(0); i++)
{
    for (var j = 0; j < my3Array.GetLength(1); j++)
    {
        for (var k = 0; k < my3Array.GetLength(2); k++)
        {
            my3Array[i,j,k] = count;
            count++;
        }
    }
}

for (var i = 0; i < my3Array.GetLength(0); i++)
{
    for (var j = 0; j < my3Array.GetLength(1); j++)
    {
        for (var k = 0; k < my3Array.GetLength(2); k++)
        {
            Console.WriteLine(my3Array[i,j,k] + $" - Строка: {i + 1}; Столбец: {j + 1}; Ширина: {k + 1}");
        }
    }
}

//Заполните спирально массив 4 на 4.
//1 2 3 4
//12 13 14 5
//11 16 15 6
//10 9 8 7

m = 4;
n = 4;

result = new int[m, n];
result[0, 0] = 1;

int el = m * n;
posX = 0;
posY = 0;
bool up = false;
bool right = true;
bool down = false;
bool left = false;

for (var i = 2; i <= el; i++)
{
    if(up && (posX - 1 < 0 || result[posX - 1, posY] != 0))//UP
    {
        right = true;
        up = false;
        down = false;
        left = false;
    }
    else if(right && (posY + 1 == m || result[posX, posY + 1] != 0))//Right
    {
        right = false;
        up = false;
        down = true;
        left = false;
    }
    else if(down && (posX + 1 == n || result[posX + 1, posY] != 0))//Down
    {
        right = false;
        up = false;
        down = false;
        left = true;
    }
    else if(left && (posY - 1 < 0 || result[posX, posY - 1] != 0))//Left
    {
        right = false;
        up = true;
        down = false;
        left = false;
    }

    if(up)
    {
        posX--;
        result[posX, posY] = i;
    }
    else if(right)
    {
        posY++;
        result[posX, posY] = i;
    }
    else if(down)
    {
        posX++;
        result[posX, posY] = i;
    }
    else if(left)
    {
        posY--;
        result[posX, posY] = i;
    }
}
Console.WriteLine("Спиральная матрица");
PrintArray(result);

//Дополнительная задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника

Console.Write("Кол-во строк треугольника Паскаля: ");
n = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    for (int c = 0; c <= (n - i); c++)
    {
        Console.Write(" "); 
    }
    for (int c = 0; c <= i; c++)
    {
        Console.Write(" " + (factorial(i) / (factorial(c) * factorial(i - c))));
    }
    Console.WriteLine();
}
