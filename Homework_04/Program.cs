//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

// Console.Write("Напишите число: ");
// int _number = Convert.ToInt32(Console.ReadLine());
// Console.Write("Возведем в степень: ");
// int _numberPow = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Получается " + Pow(_number, _numberPow));

// int Pow(int number, int pow){
//     int result = 1;
//     for(int i = 0; i < pow; i++){
//         result *= number;
//     }
//     return result;
// }

//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

// Console.Write("Напишите число: ");
// string _strNumber = Console.ReadLine();

// int _summ = 0;
// for(int i = 0; i < _strNumber.Length; i++){
//     _summ += Convert.ToInt32(_strNumber[i].ToString());
// }

// Console.WriteLine("Сумма цифр: " + _summ);

//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

// Console.Write("Введите числа через запятую: ");
// string _numbers = Console.ReadLine();
// _numbers = _numbers.Replace(" ", "");
// string[] _arrayNumbers = _numbers.Split(new char[] {','});

// for(int i = 0; i < _arrayNumbers.Length; i++){
//     Console.Write($"{_arrayNumbers[i]} ");
// }

//Второй вариант решения задачи

Console.Write("Введите числа через запятую: ");
string _numbers = Console.ReadLine();

int _countNumbers = 1;

for(int i = 0; i < _numbers.Length; i++){
    if(_numbers[i] == ','){
        _countNumbers++;
    }
}

int[] _numersArr = new int[_countNumbers];
int _index = 0;

for(int i = 0; i < _numbers.Length; i++){
    string tempString = "";
    
    while(_numbers[i] != ','){
        if(i != _numbers.Length - 1){
            tempString += _numbers[i].ToString();
            i++;
        }
        else{
            tempString += _numbers[i].ToString();
            break;
        }
    }
    _numersArr[_index] = Convert.ToInt32(tempString);
    _index++;
}

for(int i = 0; i < _numersArr.Length; i++){
    Console.Write(_numersArr[i] + " ");
}