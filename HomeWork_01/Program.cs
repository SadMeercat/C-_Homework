Console.Write("Number: ");
string number = "";
number = Console.ReadLine();
//First option
string lastNumber = Convert.ToString(number[number.Length-1]);
Console.WriteLine(lastNumber);

//Second option

int resultNum = Convert.ToInt32(number)%10;
Console.WriteLine(resultNum);