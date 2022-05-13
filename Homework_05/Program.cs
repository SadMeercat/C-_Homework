Random rnd = new Random();
int rndVal = 10;

int[] RndArr(int count, int minVal = 0, int maxVal = 0)
{
    Random rnd = new Random();
    int[] numbers = new int[rnd.Next(20)];

    Console.WriteLine("Количество элементов в массиве: " + numbers.Length);

    if(minVal == 0 && maxVal == 0)
    {
        for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = rnd.Next(100);
            Console.Write(numbers[i] + " ");
        }
    }
    else
    {
        for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = rnd.Next(minVal, maxVal);
            Console.Write(numbers[i] + " ");
        }
    }

    Console.WriteLine();
    return numbers;
}

//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] numbers = RndArr(rnd.Next(rndVal), 100, 999);

int count = 0;
for(int i = 0; i < numbers.Length; i++)
{
    if(numbers[i]%2==0)
    {
        count++;
    }
}

Console.WriteLine("Количество четных чисел в массиве: " + count);
Console.WriteLine("-----------------------------------");
//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

numbers = RndArr(rnd.Next(rndVal));

int summ = 0;

for(int i = 1; i < numbers.Length; i+=2)
{
    summ += numbers[i];
}

Console.WriteLine("Сумма чисел на нечетных позициях: " + summ);
Console.WriteLine("-----------------------------------");

//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

numbers = RndArr(rnd.Next(rndVal));
int minVal = numbers[0], maxVal = 0;

for(int i = 0; i < numbers.Length; i++)
{
    if(numbers[i] > maxVal)
    {
        maxVal = numbers[i];
    }
    if(numbers[i] < minVal)
    {
        minVal = numbers[i];
    }
}

Console.WriteLine("Разница между самым большим и самым маленьким числом: " + (maxVal - minVal));