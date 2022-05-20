using System;
//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Ваше число N: ");
int n = Convert.ToInt32(Console.ReadLine());

for (var i = n; i > 0; i--)
{
    if (i == 1)
    {
        Console.WriteLine(i);   
    }
    else
    {
        Console.Write(i + ", ");
    }
}

Console.WriteLine();

//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

Console.Write("Ваше число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Ваше число N: ");
n = Convert.ToInt32(Console.ReadLine());

int summ = 0;
if(m > n)
{
    for (var i = n ; i <= m; i++)
    {
        summ += i;
    }
}
else
{
    for (var i = m ; i <= n; i++)
    {
        summ += i;
    }
}

Console.WriteLine($"M = {m}; N = {n} -> {summ}");
Console.WriteLine();

//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 29

Console.Write("Ваше число M: ");
m = Convert.ToInt32(Console.ReadLine());

Console.Write("Ваше число N: ");
n = Convert.ToInt32(Console.ReadLine());

if(m >= 0 && n >= 0)
{
    Console.WriteLine($"Результат: {Accer(n, m)}");
}
else
{
    Console.WriteLine($"Чел, оно не будет так работь...");
}

int Accer(int n, int m)
{
    if (n == 0) 
        return m + 1;
    else if (n > 0 && m == 0) 
        return Accer(n - 1, 1);
    else if (n > 0 && m > 0) 
        return Accer(n - 1, Accer(n, m - 1));
    return Accer(n,m);
}