//Напишите программу, которая на вход
//принимает два числа и выдаёт, какое число большее, а
//какое меньшее.

Console.Write("Первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number1 > number2)
{
    Console.WriteLine(number1 + " > " + number2);
}
else if (number1 == number2)
{
    Console.WriteLine(number1 + " = " + number2);
}
else
{
    Console.WriteLine(number1 + " < " + number2);
}

//Напишите программу, которая принимает на
//вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Первое число: ");
number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Второе число: ");
number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

if(number1 > number2 && number1 > number3)
{
    Console.WriteLine(number1 + " - самое большое число!");
}
else if(number2 > number1 && number2 > number3)
{
    Console.WriteLine(number2 + " - самое большое число!");
}
else if(number3 > number1 && number1 > number2)
{
    Console.WriteLine(number3 + " - самое большое число!");
}

//Напишите программу, которая на вход
//принимает число и выдаёт, является ли число чётным
//(делится ли оно на два без остатка).

Console.Write("Ваше число: ");
int myNumber = Convert.ToInt32(Console.ReadLine());

if(myNumber % 2 == 0)
{
    Console.WriteLine(myNumber + " делится на 2");
}
else
{
    Console.WriteLine(myNumber + " НЕ делится на 2");
}

//Напишите программу, которая на вход
//принимает число (N), а на выходе показывает все чётные
//числа от 1 до N.

Console.Write("Число N: ");
int n = Convert.ToInt32(Console.ReadLine());

for (var i = 1; i <= n; i++)
{
    if(i % 2 == 0)
    {
        Console.Write(i + " ");
    }
}
Console.WriteLine();

//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа. 456 -> 6 782 -> 2 918 -> 8

Console.Write("Number: ");
string number = "";
number = Console.ReadLine();
//First option
string lastNumber = Convert.ToString(number[number.Length-1]);
Console.WriteLine(lastNumber);

//Second option

int resultNum = Convert.ToInt32(number)%10;
Console.WriteLine(resultNum);
