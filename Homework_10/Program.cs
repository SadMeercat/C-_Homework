/*
Задача 73: Есть число N. Сколько групп M, можно получить при разбиении всех чисел на группы, так чтобы в одной группе все числа были взаимно просты (все числа в группе друг на друга не делятся)? Найдите M при заданном N и получите одно из разбиений на группы N ≤ 10²⁰. Можно использовать рекурсию.
Например, для N = 50, M получается 6
Группа 1: 1
Группа 2: 2 3 11 13 17 19 23 29 31 37 41 43 47
Группа 3: 4 6 9 10 14 15 21 22 25 26 33 34 35 38 39 46 49
Группа 4: 8 12 18 20 27 28 30 42 44 45 50
Группа 5: 7 16 24 36 40
Группа 6: 5 32 48

Или
Группа 1: 1
Группа 2: 2 3 5 7 11 13 17 19 23 29 31 37 41 43 47
Группа 3: 4 6 9 10 14 15 21 22 25 26 33 34 35 38 39 46 49
Группа 4: 8 12 18 20 27 28 30 42 44 45 50
Группа 5: 16 24 36 40
Группа 6: 32 48
*/

Console.Write("Число N: ");
int n = 50;
//Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[n];
for (var i = 0; i < numbers.Length; i++)
{
    numbers[i] = i + 1;
}

int countFreeNum = 0;
int countGroups = 0;

while(countFreeNum != n)
{
    //Console.WriteLine(countFreeNum);
    int[] tempArray = new int[1];
    if(countFreeNum == 0)
    {
        tempArray[0] = numbers[countFreeNum];
        numbers[countFreeNum] = 0;
        countFreeNum++;
        countGroups++;
        PrintArray(tempArray);
        continue;
    }
    for (var i = 0; i < numbers.Length; i++)
    {
        if(numbers[i] == 0)
        {
            continue;
        }
        if(tempArray.Length == 1 && tempArray[0] == 0)
        {
            tempArray[0] = numbers[i];
            numbers[i] = 0;
            countFreeNum++;
            continue;
        }
        else if(tempArray[0] != 0)
        {
            bool access = true;
            for (var j = 0; j < tempArray.Length; j++)
            {
                if(!Evklid(numbers[i], tempArray[j]))
                {
                    access = false;
                    break;
                }
            }
            if(access)
            {
                Array.Resize(ref tempArray, tempArray.Length + 1);
                tempArray[tempArray.Length - 1] = numbers[i];
                countFreeNum++;
                numbers[i] = 0;
            }
        }
    }
    countGroups++;
    PrintArray(tempArray);
}

void PrintArray(int[] array)
{
    Console.WriteLine($"Группа {countGroups}: ");
    for (var i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

bool Evklid(int m, int n)
{
    int nod;
    while(m != n)
    {
        if(m > n)
        {
            m -= n;
        }
        else
        {
            n -= m;
        }
    }
    nod = n;

    if(nod == 1)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.WriteLine("-----------------------------------------------");
/*
Задача 74*: 4 друга должны посетить 12 пабов, 
в котором выпить по британской пинте пенного напитка. 
До каждого бара идти примерно 15-20 минут, каждый пьет пинту за 15 минут. 
У первого друга лимит выпитого 1.1 литра, у второго 1.5, у третьего 2.2 литра, 
у 4 - 3.3 литра, это их максимум. 
Необходимо выяснить, до скольки баров смогут дойти каждый из друзей
(Пройденное расстояние (в барах)), пока не упадет. 
И сколько всего времени будет потрачено на выпивку.
*/

double[] limits = new double[4] {1.1, 2.5, 2.2, 40};
int durationDrink = 15;
int maxPubs = 12;
int[] durationWalk = new int[maxPubs];

Random rnd = new Random();
Console.WriteLine("Временные расстояния: ");
for (var i = 0; i < durationWalk.Length; i++)
{
    durationWalk[i] = rnd.Next(15, 20);
    Console.Write(durationWalk[i] + " ");
}
Console.WriteLine();

for (var i = 0; i < limits.Length; i++)
{
    Console.WriteLine($"Друг {i + 1}");
    Counting(limits[i], 0);
}

void Counting(double limit, int countPubs)
{
    if(limit - 0.57 > 0 && countPubs != maxPubs)
    {
        countPubs++;
        Counting(limit - 0.57, countPubs);
    }
    else if(countPubs == maxPubs)
    {
        double multWalk = 0;
        for (var i = 0; i < countPubs; i++)
        {
            multWalk += durationWalk[i];
        }
        double resultDuration = durationDrink * countPubs + multWalk;
        Console.WriteLine($"Потрачено времени в пустую до падения на дно: {Math.Round(resultDuration, 2)}");
        Console.WriteLine($"Столько пабов поспособствовало: {countPubs}");
        Console.WriteLine($"Всего времени пил: {Math.Round(resultDuration - multWalk, 2)}");
        return;
    }
    else
    {
        double resultDuration = durationDrink * countPubs;
        double multWalk = 0;
        countPubs++;
        for (var i = 0; i < countPubs; i++)
        {
            multWalk += durationWalk[i];
        }
        resultDuration += multWalk;
        resultDuration += (limit * durationDrink / 0.57);

        Console.WriteLine($"Потрачено времени в пустую до падения на дно: {Math.Round(resultDuration, 2)}");
        Console.WriteLine($"Столько пабов поспособствовало: {countPubs}");
        Console.WriteLine($"Всего времени пил: {Math.Round(resultDuration - multWalk, 2)}");
    }
}