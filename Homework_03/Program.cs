// Напишите программу, которая принимает на
// вход пятизначное число и проверяет, является ли оно
// палиндромом

Console.Write("Введите пятизначное число: ");
string _number = Console.ReadLine();

bool _notPolind = true;
for(int i = 0; i < _number.Length / 2; i++){
    if(_number[i] != _number[_number.Length - i - 1]){
        _notPolind = false;
        break;
    }
}
if(_notPolind){
    Console.WriteLine("Введенное число - полиндром!");
}
else{
    Console.WriteLine("Введенное число - не полиндром");
}

//Напишите программу, которая принимает на
//вход координаты двух точек и находит расстояние между
//ними в 3D пространстве

int[,] _dots = new int[2,3];

for(int i = 0; i < 2; i++){
    Console.Write($"x{i+1} = ");
    _dots[i,0] = Convert.ToInt32(Console.ReadLine());
    Console.Write($"y{i+1} = ");
    _dots[i,1] = Convert.ToInt32(Console.ReadLine());
    Console.Write($"z{i+1} = ");
    _dots[i,2] = Convert.ToInt32(Console.ReadLine());
}

double _result = Math.Sqrt(Math.Pow(_dots[0,0]-_dots[1,0],2)+Math.Pow(_dots[0,1]-_dots[1,1],2)+Math.Pow(_dots[0,2]-_dots[1,2],2));
Console.WriteLine("Расстояние между точками: " + _result);

//Напишите программу, которая принимает на
//вход число (N) и выдет таблицу кубов чисел от 1 до N

Console.Write("Введите N: ");
int _n = Convert.ToInt32(Console.ReadLine());

double[] _resultPows = new double[_n];
for(int i = 1; i <= _n; i++){
    _resultPows[i-1] = Math.Pow(i, 3);
}
for(int i = 0; i < _resultPows.Length; i++){
    if(i<_resultPows.Length-1){
        Console.Write($"{_resultPows[i]}, ");
    }
    else{
        Console.WriteLine(_resultPows[i]);
    }
}
