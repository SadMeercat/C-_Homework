// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.Write("Введите трехзначное число: ");

string _numberTask1 = Console.ReadLine();
Console.WriteLine(_numberTask1[1]);

// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");

string _numberTask2 = Console.ReadLine();

if(_numberTask2.Length >= 3){
    Console.WriteLine(_numberTask2[2]);
}
else{
    Console.WriteLine(_numberTask2 + " - не трехзначное число!");
}

//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите день недели: ");
int _numberDay = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(_numberDay + " - " + CheckDay(_numberDay));
bool CheckDay(int dayNumber){
    if(dayNumber < 6 || dayNumber > 7){
        return false;
    }
    else{
        return true;
    }
}