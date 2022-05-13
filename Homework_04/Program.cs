//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.Write("Напишите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Возведем в степень: ");
int numberPow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Получается " + Pow(number, numberPow));

int Pow(int number, int pow)
{
    int result = 1;
    for(int i = 0; i < pow; i++)
    {
        result *= number;
    }
    return result;
}

//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.Write("Напишите число: ");
string strNumber = Console.ReadLine();

int summ = 0;
for(int i = 0; i < strNumber.Length; i++)
{
    summ += Convert.ToInt32(strNumber[i].ToString());
}

Console.WriteLine("Сумма цифр: " + summ);

//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

Console.Write("Введите числа через запятую: ");
string numbers = Console.ReadLine();
string[] arrayNumbers = numbers.Split(new char[] {','});

for(int i = 0; i < arrayNumbers.Length; i++)
{
    Console.Write($"{arrayNumbers[i]} ");
}
Console.WriteLine();

//Второй вариант решения задачи

Console.Write("Введите числа через запятую: ");
numbers = Console.ReadLine();

int countNumbers = 1;

for(int i = 0; i < numbers.Length; i++)
{
    if(numbers[i] == ','){
        countNumbers++;
    }
}

int[] numersArr = new int[countNumbers];
int index = 0;

for(int i = 0; i < numbers.Length; i++)
{
    string tempString = "";
    
    while(numbers[i] != ','){
        if(i != numbers.Length - 1){
            tempString += numbers[i].ToString();
            i++;
        }
        else{
            tempString += numbers[i].ToString();
            break;
        }
    }
    numersArr[index] = Convert.ToInt32(tempString);
    index++;
}

for(int i = 0; i < numersArr.Length; i++)
{
    Console.Write(numersArr[i] + " ");
}