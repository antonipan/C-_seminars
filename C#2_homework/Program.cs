/* 
// Задача №10

Console.Clear();
Console.WriteLine("Задача №10");

Console.WriteLine("Введите любое трёзначное чилсо");

int num111 = Convert.ToInt32(Console.ReadLine());

int num110 = num111/10;
int num010 = num110%10;

Console.WriteLine(num010); */

 // Задача №13

Console.WriteLine("Задача №13");

Console.WriteLine("Введите любое число");

int num1 = Convert.ToInt32(Console.ReadLine());
int count = 10;
if (num1 > 99)
{
    while (num1 > 999)
    {
        num1 = num1/count;
        Console.WriteLine(num1);
    }
    int itog = num1%10;
    Console.WriteLine(itog);
}
else
{
    Console.WriteLine("Это число не трёхзначное");
}

// Задача №16

Console.WriteLine("Задача №16");

Console.WriteLine("Введите число дня недели");

int day = Convert.ToInt32(Console.ReadLine());
if ((day > 0) & (day < 6)) 
{
    Console.WriteLine("Сегодня не выходной");
} else if ((day == 6) | (day ==7)) 
{
    Console.WriteLine("Ура! Сегодня выходной");
} 
else
{
    Console.WriteLine("Такого дня недели ещё не придумали");
} */