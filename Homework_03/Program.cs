// Напишите программу, которая принимает на
// вход пятизначное число и проверяет, является ли оно
// палиндромом

Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine();

bool notPolind = true;
for(int i = 0; i < number.Length / 2; i++)
{
    if(number[i] != number[number.Length - i - 1])
    {
        notPolind = false;
        break;
    }
}
if(notPolind)
{
    Console.WriteLine("Введенное число - полиндром!");
}
else
{
    Console.WriteLine("Введенное число - не полиндром");
}

//Напишите программу, которая принимает на
//вход координаты двух точек и находит расстояние между
//ними в 3D пространстве

int[,] dots = new int[2,3];

for(int i = 0; i < 2; i++)
{
    Console.Write($"x{i+1} = ");
    dots[i,0] = Convert.ToInt32(Console.ReadLine());
    Console.Write($"y{i+1} = ");
    dots[i,1] = Convert.ToInt32(Console.ReadLine());
    Console.Write($"z{i+1} = ");
    dots[i,2] = Convert.ToInt32(Console.ReadLine());
}

double result = Math.Sqrt(Math.Pow(dots[0,0]-dots[1,0],2)+Math.Pow(dots[0,1]-dots[1,1],2)+Math.Pow(dots[0,2]-dots[1,2],2));
Console.WriteLine("Расстояние между точками: " + result);

//Напишите программу, которая принимает на
//вход число (N) и выдет таблицу кубов чисел от 1 до N

Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

double[] resultPows = new double[n];
for(int i = 1; i <= n; i++)
{
    resultPows[i-1] = Math.Pow(i, 3);
}
for(int i = 0; i < resultPows.Length; i++)
{
    if(i<resultPows.Length-1)
    {
        Console.Write($"{resultPows[i]}, ");
    }
    else
    {
        Console.WriteLine(resultPows[i]);
    }
}
