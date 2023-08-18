int Prompt (string msg)
{

System.Console.WriteLine(msg);
string value = Console.ReadLine()
int result = Console.ToInt32(value);
return result;
}


int number = Prompt("Введите трехзначное число> ");
if (number < 100 || number >= 1000)
{

Console.WriteLine ("Вы ввели не трехзначное число");
    return;
}


Console.WriteLine($" число '{number}'");
int secondRank = number / 10 % 10 ;
Console.WriteLine($"Вторая цифра'{secondRank}'");
