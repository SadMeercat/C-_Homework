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
    if(dayNumber % 6 == 0 || dayNumber % 7 == 0){
        return true;
    }
    else{
        return false;
    }
}

//Игра угадайка. Программа загадывает случайное число. Пользователь его угадывает. Если пользователь дает неправильный ответ, то программа сообщает, больше загаданное число или меньше

Random rnd = new Random();
int _randomNumber = rnd.Next(0,100);

bool _access = false;
Console.Write($"Поробуй угадать число {_randomNumber}. Введите число: ");
int _numberAtt = Convert.ToInt32(Console.ReadLine());
for(int i = 0; i < 3; i++){
    switch  (CheckNumber(_numberAtt)){
        case 0: {
            _access = true;
            break;
        }
        case 1:{
            Console.WriteLine("Мое число больше");
            break;
        }
        case 2:{
            Console.WriteLine("Мое число меньше");
            break;
        }
    }
    if(_access){
        break;
    }
    else{
        Console.Write("Введи число: ");
        _numberAtt = Convert.ToInt32(Console.ReadLine());
    }
}

if(_access){
    Console.WriteLine("Ты победил!");
}
else{
    Console.WriteLine("Ты проиграл. Увы...");
}

int CheckNumber(int number){
    if(number == _randomNumber){
        return 0;
    }
    else{
        if(number > _randomNumber){
            return 1;
        }
        else{
            return 2;
        }
    }
}
