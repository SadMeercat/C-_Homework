int[] StrToArray(string inptStr = "")
{
    int countNumbers = 1;

    for(int i = 0; i < inptStr.Length; i++)
    {
        if(inptStr[i] == ',')
        {
            countNumbers++;
        }
    }

    int[] numersArr = new int[countNumbers];
    int index = 0;

    for(int i = 0; i < inptStr.Length; i++)
    {
        string tempString = "";
        
        while(inptStr[i] != ',')
        {
            if(i != inptStr.Length - 1)
            {
                tempString += inptStr[i].ToString();
                i++;
            }
            else
            {
                tempString += inptStr[i].ToString();
                break;
            }
        }
        numersArr[index] = Convert.ToInt32(tempString);
        index++;
    }
    return numersArr;
}

//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//-1, -7, 567, 89, 223-> 3

Console.Write("Введите числа через запятую: ");
int[] numbers = StrToArray(Console.ReadLine());

int count = 0;
for (var i = 0; i < numbers.Length; i++)
{
    Console.Write(numbers[i] + " ");
    if(numbers[i] > 0)
    {
        count++;
    }
}

Console.WriteLine("-> " + count);

//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

Console.Write("k1 = ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("b1 = ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("k2 = ");
double k2 = Convert.ToDouble(Console.ReadLine());

Console.Write("b2 = ");
double b2 = Convert.ToDouble(Console.ReadLine());

double x = -(b1 - b2)/(k1 - k2);
double y = k2 * x + b2;

Console.WriteLine("x = " + x + "; y = " + y);